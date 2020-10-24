namespace DLLandCOM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ManagedFacButton = new System.Windows.Forms.Button();
            this.ManagedFabButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.UnmanagedFacButton = new System.Windows.Forms.Button();
            this.UnmanagedFabButton = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.FabInputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FabOutputTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FacInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FacOutputTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 85);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 53);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "托管";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ManagedFacButton);
            this.flowLayoutPanel1.Controls.Add(this.ManagedFabButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ManagedFacButton
            // 
            this.ManagedFacButton.Location = new System.Drawing.Point(3, 3);
            this.ManagedFacButton.Name = "ManagedFacButton";
            this.ManagedFacButton.Size = new System.Drawing.Size(104, 34);
            this.ManagedFacButton.TabIndex = 2;
            this.ManagedFacButton.Text = "反射阶乘";
            this.ManagedFacButton.UseVisualStyleBackColor = true;
            this.ManagedFacButton.Click += new System.EventHandler(this.ManagedFacButton_Click);
            // 
            // ManagedFabButton
            // 
            this.ManagedFabButton.Location = new System.Drawing.Point(113, 3);
            this.ManagedFabButton.Name = "ManagedFabButton";
            this.ManagedFabButton.Size = new System.Drawing.Size(144, 34);
            this.ManagedFabButton.TabIndex = 3;
            this.ManagedFabButton.Text = "反射斐波那契";
            this.ManagedFabButton.UseVisualStyleBackColor = true;
            this.ManagedFabButton.Click += new System.EventHandler(this.ManagedFabButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 53);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "非托管";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.UnmanagedFacButton);
            this.flowLayoutPanel2.Controls.Add(this.UnmanagedFabButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(222, 42);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // UnmanagedFacButton
            // 
            this.UnmanagedFacButton.Location = new System.Drawing.Point(3, 3);
            this.UnmanagedFacButton.Name = "UnmanagedFacButton";
            this.UnmanagedFacButton.Size = new System.Drawing.Size(104, 34);
            this.UnmanagedFacButton.TabIndex = 0;
            this.UnmanagedFacButton.Text = "阶乘";
            this.UnmanagedFacButton.UseVisualStyleBackColor = true;
            this.UnmanagedFacButton.Click += new System.EventHandler(this.UnmanagedFacButton_Click);
            // 
            // UnmanagedFabButton
            // 
            this.UnmanagedFabButton.Location = new System.Drawing.Point(113, 3);
            this.UnmanagedFabButton.Name = "UnmanagedFabButton";
            this.UnmanagedFabButton.Size = new System.Drawing.Size(104, 34);
            this.UnmanagedFabButton.TabIndex = 1;
            this.UnmanagedFabButton.Text = "斐波那契";
            this.UnmanagedFabButton.UseVisualStyleBackColor = true;
            this.UnmanagedFabButton.Click += new System.EventHandler(this.UnmanagedFabButton_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 13);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(784, 303);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel4);
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 271);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "DLL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.FabInputTextBox);
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.FabOutputTextBox);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(7, 199);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(759, 42);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "斐波那契输入：";
            // 
            // FabInputTextBox
            // 
            this.FabInputTextBox.Font = new System.Drawing.Font("宋体", 10F);
            this.FabInputTextBox.Location = new System.Drawing.Point(217, 5);
            this.FabInputTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.FabInputTextBox.Name = "FabInputTextBox";
            this.FabInputTextBox.Size = new System.Drawing.Size(112, 30);
            this.FabInputTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(335, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "斐波那契输出：";
            // 
            // FabOutputTextBox
            // 
            this.FabOutputTextBox.Font = new System.Drawing.Font("宋体", 10F);
            this.FabOutputTextBox.Location = new System.Drawing.Point(549, 5);
            this.FabOutputTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.FabOutputTextBox.Name = "FabOutputTextBox";
            this.FabOutputTextBox.Size = new System.Drawing.Size(167, 30);
            this.FabOutputTextBox.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.FacInputTextBox);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.FacOutputTextBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(7, 123);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(759, 42);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "阶乘输入：";
            // 
            // FacInputTextBox
            // 
            this.FacInputTextBox.Font = new System.Drawing.Font("宋体", 10F);
            this.FacInputTextBox.Location = new System.Drawing.Point(161, 4);
            this.FacInputTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.FacInputTextBox.Name = "FacInputTextBox";
            this.FacInputTextBox.Size = new System.Drawing.Size(132, 30);
            this.FacInputTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(299, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "阶乘输出：";
            // 
            // FacOutputTextBox
            // 
            this.FacOutputTextBox.Font = new System.Drawing.Font("宋体", 10F);
            this.FacOutputTextBox.Location = new System.Drawing.Point(457, 4);
            this.FacOutputTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.FacOutputTextBox.Name = "FacOutputTextBox";
            this.FacOutputTextBox.Size = new System.Drawing.Size(259, 30);
            this.FacOutputTextBox.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 271);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "COM";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "第三周实验";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ManagedFacButton;
        private System.Windows.Forms.Button ManagedFabButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button UnmanagedFacButton;
        private System.Windows.Forms.Button UnmanagedFabButton;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FacInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FacOutputTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FabInputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FabOutputTextBox;
    }
}

