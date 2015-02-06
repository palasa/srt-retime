using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace srt字幕修正器
{
    public partial class form1 : Form
    {
        private static string fileContent = String.Empty;
        public form1()
        {
            InitializeComponent();
        }

        private void srtFileBox_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.srtFileBox.Text = this.openFileDialog1.FileName;
                if (System.IO.Path.GetExtension(this.srtFileBox.Text) != ".srt")
                {
                    MessageBox.Show("文件格式错误!");
                    this.srtFileBox.Text = "";
                    return;
                }
                GetFile();
            }
            
        }




        private void form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else e.Effect = DragDropEffects.None;
        }

        private void form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.srtFileBox.Text = path;
            if (System.IO.Path.GetExtension(this.srtFileBox.Text) != ".srt")
            {
                MessageBox.Show("文件格式错误!");
                this.srtFileBox.Text = "";
                return;
            }
            GetFile();
        }


        #region + -
        private void buttonPlus1_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            ChangeTime(1);
        }



        private void buttonPlusPoint1_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            ChangeTime(0.1);
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            ChangeTime(-1);
        }

        private void btnMinusPoint1_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            ChangeTime(-0.1);
        }

        private void btnMinus10_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            ChangeTime(-10);
        }

        private void buttonPlus10_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            ChangeTime(10);
        }

        private void buttonPlus60_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            ChangeTime(60);
        }

        private void btnMinus60_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            ChangeTime(-60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileContent == string.Empty || fileContent == "")
            {
                MessageBox.Show("请先选择文件");
                return;
            }

            if (this.txtTime.Text == "")
            {
                MessageBox.Show("请输入时间！");
                return;
            }
            double t;
            try
            {
                t = Convert.ToDouble(this.txtTime.Text);
                if (Math.Abs(t) > 10000)
                    throw new Exception("时间过长");
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入的时间格式不正确！");
                return;
            }
            
            ChangeTime(t);
        }

        #endregion

        /// <summary>
        /// read file
        /// </summary>
        private void GetFile()
        {
            
            using (FileStream srtFileStream = new FileStream(this.srtFileBox.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(srtFileStream,Encoding.Default,true))
                {
                    fileContent = sr.ReadToEnd();
                }
                this.toolStripStatusLabel1.Text = "已成功读取文件";
                /*
                byte[] data = new byte[1 * 1024 * 1024];
                while (srtFileStream.Read(data, 0, data.Length) > 0)
                {
                    fileContent += Encoding.UTF8.GetString(data);
                }
                 * */
            }
        }


        private void ChangeTime(double second)
        {
            Regex reg = new Regex(@"\d\d\:\d\d\:\d\d,\d{3}");
            fileContent = reg.Replace(fileContent, new MatchEvaluator(delegate(Match m)
            {
                //    // 00:35:06,733
                //    //  0  1  2  3
                var timeStrArray = m.Groups[0].ToString().Split(new char[] { ':', ',' });
                int[] timeIntArray = new int[4];
                for (int i = 0; i < timeStrArray.Length; i++)
                {
                    timeIntArray[i] = Convert.ToInt32(timeStrArray[i]);
                }
                var originTime = new DateTime(2000, 1, 1, timeIntArray[0], timeIntArray[1], timeIntArray[2], timeIntArray[3]);
                var calulatedTime = originTime.AddSeconds(second);
                var replacement = string.Empty;
                string hour = calulatedTime.Hour <= 9 ? "0" + calulatedTime.Hour : calulatedTime.Hour.ToString(),
                    minute = calulatedTime.Minute <= 9 ? "0" + calulatedTime.Minute : calulatedTime.Minute.ToString(),
                    sec = calulatedTime.Second <= 9 ? "0" + calulatedTime.Second : calulatedTime.Second.ToString();
                string milli;
                if (calulatedTime.Millisecond <= 9)
                    milli = "00" + calulatedTime.Millisecond;
                else if (calulatedTime.Millisecond <= 99)
                    milli = "0" + calulatedTime.Millisecond;
                else
                    milli = calulatedTime.Millisecond.ToString();
                replacement = string.Format("{0}:{1}:{2},{3}",
                    hour, minute, sec, milli);
                return replacement;
            }));

            // write file
            using (FileStream fs = new FileStream(this.srtFileBox.Text, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
                sw.Write(fileContent);
                sw.Flush();
            }
           
            this.toolStripStatusLabel1.Text = "已成功调整" + second + "秒";
        }

        private void form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
