namespace SimplePendulum
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudM = new System.Windows.Forms.NumericUpDown();
            this.nudLenght = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblY = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlphaNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudForceValue = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudForceValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Paper);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 343);
            this.panel1.TabIndex = 0;
            // 
            // Paper
            // 
            this.Paper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Paper.BackColor = System.Drawing.Color.White;
            this.Paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paper.Location = new System.Drawing.Point(12, 12);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(905, 343);
            this.Paper.TabIndex = 0;
            this.Paper.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDirection);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nudForceValue);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.nudM);
            this.groupBox1.Controls.Add(this.nudLenght);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(174, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉ số";
            // 
            // nudM
            // 
            this.nudM.Location = new System.Drawing.Point(136, 24);
            this.nudM.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudM.Name = "nudM";
            this.nudM.Size = new System.Drawing.Size(57, 22);
            this.nudM.TabIndex = 15;
            this.nudM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLenght
            // 
            this.nudLenght.Location = new System.Drawing.Point(136, 53);
            this.nudLenght.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLenght.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudLenght.Name = "nudLenght";
            this.nudLenght.Size = new System.Drawing.Size(57, 22);
            this.nudLenght.TabIndex = 3;
            this.nudLenght.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chiều dài con lắc (l)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khối lượng";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnStart.Location = new System.Drawing.Point(53, 384);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPause.Location = new System.Drawing.Point(53, 418);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblY);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblX);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAlphaNew);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(589, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 117);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá trị";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblY.ForeColor = System.Drawing.Color.Blue;
            this.lblY.Location = new System.Drawing.Point(250, 59);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 16);
            this.lblY.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(221, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "(y) : ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblX.ForeColor = System.Drawing.Color.Blue;
            this.lblX.Location = new System.Drawing.Point(249, 32);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 16);
            this.lblX.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(221, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "(x) :";
            // 
            // txtAlphaNew
            // 
            this.txtAlphaNew.Enabled = false;
            this.txtAlphaNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAlphaNew.Location = new System.Drawing.Point(83, 32);
            this.txtAlphaNew.Name = "txtAlphaNew";
            this.txtAlphaNew.Size = new System.Drawing.Size(132, 22);
            this.txtAlphaNew.TabIndex = 3;
            this.txtAlphaNew.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alpha(α)";
            // 
            // cmbDirection
            // 
            this.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cmbDirection.Location = new System.Drawing.Point(291, 51);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(67, 24);
            this.cmbDirection.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Hướng :";
            // 
            // nudForceValue
            // 
            this.nudForceValue.Location = new System.Drawing.Point(291, 25);
            this.nudForceValue.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudForceValue.Name = "nudForceValue";
            this.nudForceValue.Size = new System.Drawing.Size(67, 22);
            this.nudForceValue.TabIndex = 17;
            this.nudForceValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Độ lớn : ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô phòng con lắc đơn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudForceValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlphaNew;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudM;
        private System.Windows.Forms.NumericUpDown nudLenght;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudForceValue;
        private System.Windows.Forms.Label label11;
    }
}

