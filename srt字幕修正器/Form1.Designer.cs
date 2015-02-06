namespace srt字幕修正器
{
    partial class form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.srtFileBox = new System.Windows.Forms.TextBox();
            this.btnMinus60 = new System.Windows.Forms.Button();
            this.btnMinus10 = new System.Windows.Forms.Button();
            this.btnMinus1 = new System.Windows.Forms.Button();
            this.btnMinusPoint1 = new System.Windows.Forms.Button();
            this.buttonPlusPoint1 = new System.Windows.Forms.Button();
            this.buttonPlus1 = new System.Windows.Forms.Button();
            this.buttonPlus10 = new System.Windows.Forms.Button();
            this.buttonPlus60 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // srtFileBox
            // 
            this.srtFileBox.AllowDrop = true;
            this.srtFileBox.Location = new System.Drawing.Point(70, 58);
            this.srtFileBox.Name = "srtFileBox";
            this.srtFileBox.ReadOnly = true;
            this.srtFileBox.Size = new System.Drawing.Size(787, 31);
            this.srtFileBox.TabIndex = 0;
            this.srtFileBox.Text = "点击或拖拽选择需要修改的文件";
            this.srtFileBox.Click += new System.EventHandler(this.srtFileBox_Click);
            // 
            // btnMinus60
            // 
            this.btnMinus60.Location = new System.Drawing.Point(79, 190);
            this.btnMinus60.Name = "btnMinus60";
            this.btnMinus60.Size = new System.Drawing.Size(81, 37);
            this.btnMinus60.TabIndex = 1;
            this.btnMinus60.Text = "-60";
            this.btnMinus60.UseVisualStyleBackColor = true;
            this.btnMinus60.Click += new System.EventHandler(this.btnMinus60_Click);
            // 
            // btnMinus10
            // 
            this.btnMinus10.Location = new System.Drawing.Point(185, 190);
            this.btnMinus10.Name = "btnMinus10";
            this.btnMinus10.Size = new System.Drawing.Size(73, 37);
            this.btnMinus10.TabIndex = 2;
            this.btnMinus10.Text = "-10";
            this.btnMinus10.UseVisualStyleBackColor = true;
            this.btnMinus10.Click += new System.EventHandler(this.btnMinus10_Click);
            // 
            // btnMinus1
            // 
            this.btnMinus1.Location = new System.Drawing.Point(290, 190);
            this.btnMinus1.Name = "btnMinus1";
            this.btnMinus1.Size = new System.Drawing.Size(73, 37);
            this.btnMinus1.TabIndex = 3;
            this.btnMinus1.Text = "-1";
            this.btnMinus1.UseVisualStyleBackColor = true;
            this.btnMinus1.Click += new System.EventHandler(this.btnMinus1_Click);
            // 
            // btnMinusPoint1
            // 
            this.btnMinusPoint1.Location = new System.Drawing.Point(395, 190);
            this.btnMinusPoint1.Name = "btnMinusPoint1";
            this.btnMinusPoint1.Size = new System.Drawing.Size(75, 37);
            this.btnMinusPoint1.TabIndex = 4;
            this.btnMinusPoint1.Text = "-0.1";
            this.btnMinusPoint1.UseVisualStyleBackColor = true;
            this.btnMinusPoint1.Click += new System.EventHandler(this.btnMinusPoint1_Click);
            // 
            // buttonPlusPoint1
            // 
            this.buttonPlusPoint1.Location = new System.Drawing.Point(395, 266);
            this.buttonPlusPoint1.Name = "buttonPlusPoint1";
            this.buttonPlusPoint1.Size = new System.Drawing.Size(75, 37);
            this.buttonPlusPoint1.TabIndex = 8;
            this.buttonPlusPoint1.Text = "+0.1";
            this.buttonPlusPoint1.UseVisualStyleBackColor = true;
            this.buttonPlusPoint1.Click += new System.EventHandler(this.buttonPlusPoint1_Click);
            // 
            // buttonPlus1
            // 
            this.buttonPlus1.Location = new System.Drawing.Point(290, 266);
            this.buttonPlus1.Name = "buttonPlus1";
            this.buttonPlus1.Size = new System.Drawing.Size(73, 37);
            this.buttonPlus1.TabIndex = 7;
            this.buttonPlus1.Text = "+1";
            this.buttonPlus1.UseVisualStyleBackColor = true;
            this.buttonPlus1.Click += new System.EventHandler(this.buttonPlus1_Click);
            // 
            // buttonPlus10
            // 
            this.buttonPlus10.Location = new System.Drawing.Point(185, 266);
            this.buttonPlus10.Name = "buttonPlus10";
            this.buttonPlus10.Size = new System.Drawing.Size(73, 37);
            this.buttonPlus10.TabIndex = 6;
            this.buttonPlus10.Text = "+10";
            this.buttonPlus10.UseVisualStyleBackColor = true;
            this.buttonPlus10.Click += new System.EventHandler(this.buttonPlus10_Click);
            // 
            // buttonPlus60
            // 
            this.buttonPlus60.Location = new System.Drawing.Point(79, 266);
            this.buttonPlus60.Name = "buttonPlus60";
            this.buttonPlus60.Size = new System.Drawing.Size(81, 37);
            this.buttonPlus60.TabIndex = 5;
            this.buttonPlus60.Text = "+60";
            this.buttonPlus60.UseVisualStyleBackColor = true;
            this.buttonPlus60.Click += new System.EventHandler(this.buttonPlus60_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "自定义";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(609, 190);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 31);
            this.txtTime.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(957, 33);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 28);
            this.toolStripStatusLabel1.Text = "提示信息";
            // 
            // form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 565);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPlusPoint1);
            this.Controls.Add(this.buttonPlus1);
            this.Controls.Add(this.buttonPlus10);
            this.Controls.Add(this.buttonPlus60);
            this.Controls.Add(this.btnMinusPoint1);
            this.Controls.Add(this.btnMinus1);
            this.Controls.Add(this.btnMinus10);
            this.Controls.Add(this.btnMinus60);
            this.Controls.Add(this.srtFileBox);
            this.Name = "form1";
            this.Text = "srt字幕修正器";
            this.Load += new System.EventHandler(this.form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.form1_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox srtFileBox;
        private System.Windows.Forms.Button btnMinus60;
        private System.Windows.Forms.Button btnMinus10;
        private System.Windows.Forms.Button btnMinus1;
        private System.Windows.Forms.Button btnMinusPoint1;
        private System.Windows.Forms.Button buttonPlusPoint1;
        private System.Windows.Forms.Button buttonPlus1;
        private System.Windows.Forms.Button buttonPlus10;
        private System.Windows.Forms.Button buttonPlus60;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

