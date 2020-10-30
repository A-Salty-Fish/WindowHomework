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
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.MulInput1TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MulInput2TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MulOutputTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.SumInput1TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SumInput2TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SumOutputTextBox = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.WordButton = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.textBox1);
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
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(405, 42);
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
            this.FabOutputTextBox.ReadOnly = true;
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
            this.FacOutputTextBox.ReadOnly = true;
            this.FacOutputTextBox.Size = new System.Drawing.Size(259, 30);
            this.FacOutputTextBox.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl3);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 271);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "COM";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Location = new System.Drawing.Point(6, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(763, 261);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.flowLayoutPanel6);
            this.tabPage5.Controls.Add(this.flowLayoutPanel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(755, 229);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "自定义";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label8);
            this.flowLayoutPanel6.Controls.Add(this.MulInput1TextBox);
            this.flowLayoutPanel6.Controls.Add(this.label9);
            this.flowLayoutPanel6.Controls.Add(this.MulInput2TextBox);
            this.flowLayoutPanel6.Controls.Add(this.label10);
            this.flowLayoutPanel6.Controls.Add(this.MulOutputTextBox);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(7, 135);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(742, 47);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F);
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "求乘  ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // MulInput1TextBox
            // 
            this.MulInput1TextBox.Font = new System.Drawing.Font("宋体", 15F);
            this.MulInput1TextBox.Location = new System.Drawing.Point(112, 2);
            this.MulInput1TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.MulInput1TextBox.Name = "MulInput1TextBox";
            this.MulInput1TextBox.Size = new System.Drawing.Size(108, 42);
            this.MulInput1TextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(226, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            // 
            // MulInput2TextBox
            // 
            this.MulInput2TextBox.Font = new System.Drawing.Font("宋体", 15F);
            this.MulInput2TextBox.Location = new System.Drawing.Point(260, 2);
            this.MulInput2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.MulInput2TextBox.Name = "MulInput2TextBox";
            this.MulInput2TextBox.Size = new System.Drawing.Size(108, 42);
            this.MulInput2TextBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F);
            this.label10.Location = new System.Drawing.Point(374, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 30);
            this.label10.TabIndex = 4;
            this.label10.Text = "=";
            // 
            // MulOutputTextBox
            // 
            this.MulOutputTextBox.Font = new System.Drawing.Font("宋体", 15F);
            this.MulOutputTextBox.Location = new System.Drawing.Point(408, 2);
            this.MulOutputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.MulOutputTextBox.Name = "MulOutputTextBox";
            this.MulOutputTextBox.ReadOnly = true;
            this.MulOutputTextBox.Size = new System.Drawing.Size(273, 42);
            this.MulOutputTextBox.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.SumInput1TextBox);
            this.flowLayoutPanel5.Controls.Add(this.label6);
            this.flowLayoutPanel5.Controls.Add(this.SumInput2TextBox);
            this.flowLayoutPanel5.Controls.Add(this.label7);
            this.flowLayoutPanel5.Controls.Add(this.SumOutputTextBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(7, 42);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(742, 47);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "求和  ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SumInput1TextBox
            // 
            this.SumInput1TextBox.Font = new System.Drawing.Font("宋体", 15F);
            this.SumInput1TextBox.Location = new System.Drawing.Point(112, 2);
            this.SumInput1TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.SumInput1TextBox.Name = "SumInput1TextBox";
            this.SumInput1TextBox.Size = new System.Drawing.Size(108, 42);
            this.SumInput1TextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(226, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "+";
            // 
            // SumInput2TextBox
            // 
            this.SumInput2TextBox.Font = new System.Drawing.Font("宋体", 15F);
            this.SumInput2TextBox.Location = new System.Drawing.Point(260, 2);
            this.SumInput2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.SumInput2TextBox.Name = "SumInput2TextBox";
            this.SumInput2TextBox.Size = new System.Drawing.Size(108, 42);
            this.SumInput2TextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(374, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "=";
            // 
            // SumOutputTextBox
            // 
            this.SumOutputTextBox.Font = new System.Drawing.Font("宋体", 15F);
            this.SumOutputTextBox.Location = new System.Drawing.Point(408, 2);
            this.SumOutputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.SumOutputTextBox.Name = "SumOutputTextBox";
            this.SumOutputTextBox.ReadOnly = true;
            this.SumOutputTextBox.Size = new System.Drawing.Size(273, 42);
            this.SumOutputTextBox.TabIndex = 5;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.flowLayoutPanel7);
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(755, 229);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Word";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.WordButton);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(742, 40);
            this.flowLayoutPanel7.TabIndex = 0;
            // 
            // WordButton
            // 
            this.WordButton.Location = new System.Drawing.Point(3, 3);
            this.WordButton.Name = "WordButton";
            this.WordButton.Size = new System.Drawing.Size(138, 32);
            this.WordButton.TabIndex = 0;
            this.WordButton.Text = "Word COM 操作";
            this.WordButton.UseVisualStyleBackColor = true;
            this.WordButton.Click += new System.EventHandler(this.NewWordButton_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(755, 229);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Excel";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "反射函数";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(338, 36);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "第三周实验";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SumInput1TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SumInput2TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SumOutputTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MulInput1TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MulInput2TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MulOutputTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button WordButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

