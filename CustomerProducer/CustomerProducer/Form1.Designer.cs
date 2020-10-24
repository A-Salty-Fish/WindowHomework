namespace CustomerProducer
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateThreadButton = new System.Windows.Forms.Button();
            this.FrontThreadButton = new System.Windows.Forms.Button();
            this.BackThreadButton = new System.Windows.Forms.Button();
            this.JoinThreadButton = new System.Windows.Forms.Button();
            this.ManualResetButton = new System.Windows.Forms.Button();
            this.AutoResetButton = new System.Windows.Forms.Button();
            this.CusProButton = new System.Windows.Forms.Button();
            this.outPutTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateScreenshotsButton = new System.Windows.Forms.Button();
            this.StartScreenshotsButton = new System.Windows.Forms.Button();
            this.EndScreenshotsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CreateThreadButton);
            this.flowLayoutPanel1.Controls.Add(this.FrontThreadButton);
            this.flowLayoutPanel1.Controls.Add(this.BackThreadButton);
            this.flowLayoutPanel1.Controls.Add(this.JoinThreadButton);
            this.flowLayoutPanel1.Controls.Add(this.ManualResetButton);
            this.flowLayoutPanel1.Controls.Add(this.AutoResetButton);
            this.flowLayoutPanel1.Controls.Add(this.CusProButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(966, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // CreateThreadButton
            // 
            this.CreateThreadButton.Location = new System.Drawing.Point(3, 3);
            this.CreateThreadButton.Name = "CreateThreadButton";
            this.CreateThreadButton.Size = new System.Drawing.Size(132, 40);
            this.CreateThreadButton.TabIndex = 0;
            this.CreateThreadButton.Text = "创建线程";
            this.CreateThreadButton.UseVisualStyleBackColor = true;
            this.CreateThreadButton.Click += new System.EventHandler(this.CreateThreadButton_Click);
            // 
            // FrontThreadButton
            // 
            this.FrontThreadButton.Location = new System.Drawing.Point(141, 3);
            this.FrontThreadButton.Name = "FrontThreadButton";
            this.FrontThreadButton.Size = new System.Drawing.Size(132, 40);
            this.FrontThreadButton.TabIndex = 1;
            this.FrontThreadButton.Text = "前台线程";
            this.FrontThreadButton.UseVisualStyleBackColor = true;
            this.FrontThreadButton.Click += new System.EventHandler(this.FrontThreadButton_Click);
            // 
            // BackThreadButton
            // 
            this.BackThreadButton.Location = new System.Drawing.Point(279, 3);
            this.BackThreadButton.Name = "BackThreadButton";
            this.BackThreadButton.Size = new System.Drawing.Size(132, 40);
            this.BackThreadButton.TabIndex = 2;
            this.BackThreadButton.Text = "前、后台线程";
            this.BackThreadButton.UseVisualStyleBackColor = true;
            this.BackThreadButton.Click += new System.EventHandler(this.BackThreadButton_Click);
            // 
            // JoinThreadButton
            // 
            this.JoinThreadButton.Location = new System.Drawing.Point(417, 3);
            this.JoinThreadButton.Name = "JoinThreadButton";
            this.JoinThreadButton.Size = new System.Drawing.Size(132, 40);
            this.JoinThreadButton.TabIndex = 3;
            this.JoinThreadButton.Text = "Join线程";
            this.JoinThreadButton.UseVisualStyleBackColor = true;
            this.JoinThreadButton.Click += new System.EventHandler(this.JoinThreadButton_Click);
            // 
            // ManualResetButton
            // 
            this.ManualResetButton.Location = new System.Drawing.Point(555, 3);
            this.ManualResetButton.Name = "ManualResetButton";
            this.ManualResetButton.Size = new System.Drawing.Size(132, 40);
            this.ManualResetButton.TabIndex = 4;
            this.ManualResetButton.Text = "MaualReset";
            this.ManualResetButton.UseVisualStyleBackColor = true;
            this.ManualResetButton.Click += new System.EventHandler(this.ManualResetButton_Click);
            // 
            // AutoResetButton
            // 
            this.AutoResetButton.Location = new System.Drawing.Point(693, 3);
            this.AutoResetButton.Name = "AutoResetButton";
            this.AutoResetButton.Size = new System.Drawing.Size(132, 40);
            this.AutoResetButton.TabIndex = 5;
            this.AutoResetButton.Text = "AutoReset";
            this.AutoResetButton.UseVisualStyleBackColor = true;
            this.AutoResetButton.Click += new System.EventHandler(this.AutoResetButton_Click);
            // 
            // CusProButton
            // 
            this.CusProButton.Location = new System.Drawing.Point(831, 3);
            this.CusProButton.Name = "CusProButton";
            this.CusProButton.Size = new System.Drawing.Size(132, 40);
            this.CusProButton.TabIndex = 6;
            this.CusProButton.Text = "生产者消费者";
            this.CusProButton.UseVisualStyleBackColor = true;
            this.CusProButton.Click += new System.EventHandler(this.CusProButton_Click);
            // 
            // outPutTextBox
            // 
            this.outPutTextBox.Location = new System.Drawing.Point(15, 126);
            this.outPutTextBox.Multiline = true;
            this.outPutTextBox.Name = "outPutTextBox";
            this.outPutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outPutTextBox.Size = new System.Drawing.Size(960, 574);
            this.outPutTextBox.TabIndex = 1;
            this.outPutTextBox.TextChanged += new System.EventHandler(this.outPutTextBox_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CreateScreenshotsButton);
            this.flowLayoutPanel2.Controls.Add(this.StartScreenshotsButton);
            this.flowLayoutPanel2.Controls.Add(this.EndScreenshotsButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(422, 51);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // CreateScreenshotsButton
            // 
            this.CreateScreenshotsButton.Location = new System.Drawing.Point(3, 3);
            this.CreateScreenshotsButton.Name = "CreateScreenshotsButton";
            this.CreateScreenshotsButton.Size = new System.Drawing.Size(132, 40);
            this.CreateScreenshotsButton.TabIndex = 1;
            this.CreateScreenshotsButton.Text = "创建抓屏线程";
            this.CreateScreenshotsButton.UseVisualStyleBackColor = true;
            this.CreateScreenshotsButton.Click += new System.EventHandler(this.CreateScreenshotsButton_Click);
            // 
            // StartScreenshotsButton
            // 
            this.StartScreenshotsButton.Location = new System.Drawing.Point(141, 3);
            this.StartScreenshotsButton.Name = "StartScreenshotsButton";
            this.StartScreenshotsButton.Size = new System.Drawing.Size(132, 40);
            this.StartScreenshotsButton.TabIndex = 2;
            this.StartScreenshotsButton.Text = "抓屏";
            this.StartScreenshotsButton.UseVisualStyleBackColor = true;
            this.StartScreenshotsButton.Click += new System.EventHandler(this.StartScreenshotsButton_Click);
            // 
            // EndScreenshotsButton
            // 
            this.EndScreenshotsButton.Location = new System.Drawing.Point(279, 3);
            this.EndScreenshotsButton.Name = "EndScreenshotsButton";
            this.EndScreenshotsButton.Size = new System.Drawing.Size(132, 40);
            this.EndScreenshotsButton.TabIndex = 3;
            this.EndScreenshotsButton.Text = "结束抓屏线程";
            this.EndScreenshotsButton.UseVisualStyleBackColor = true;
            this.EndScreenshotsButton.Click += new System.EventHandler(this.EndScreenshotsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.outPutTextBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "实验二";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CreateThreadButton;
        private System.Windows.Forms.Button FrontThreadButton;
        private System.Windows.Forms.Button BackThreadButton;
        private System.Windows.Forms.Button JoinThreadButton;
        private System.Windows.Forms.Button ManualResetButton;
        private System.Windows.Forms.Button AutoResetButton;
        private System.Windows.Forms.TextBox outPutTextBox;
        private System.Windows.Forms.Button CusProButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button CreateScreenshotsButton;
        private System.Windows.Forms.Button StartScreenshotsButton;
        private System.Windows.Forms.Button EndScreenshotsButton;
    }
}

