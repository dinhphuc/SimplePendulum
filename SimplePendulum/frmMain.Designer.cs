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
            this.txtVo = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtAlpa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOmega = new System.Windows.Forms.TextBox();
            this.txtAlphaNew = new System.Windows.Forms.TextBox();
            this.txtPi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.Paper.Paint += new System.Windows.Forms.PaintEventHandler(this.Paper_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVo);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.txtAlpa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(234, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉ số";
            // 
            // txtVo
            // 
            this.txtVo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtVo.Location = new System.Drawing.Point(209, 78);
            this.txtVo.Name = "txtVo";
            this.txtVo.Size = new System.Drawing.Size(100, 22);
            this.txtVo.TabIndex = 1;
            this.txtVo.Text = "5";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtLength.Location = new System.Drawing.Point(209, 52);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 1;
            this.txtLength.Text = "200";
            // 
            // txtAlpa
            // 
            this.txtAlpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAlpa.Location = new System.Drawing.Point(209, 26);
            this.txtAlpa.Name = "txtAlpa";
            this.txtAlpa.Size = new System.Drawing.Size(100, 22);
            this.txtAlpa.TabIndex = 1;
            this.txtAlpa.Text = "70";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(37, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vận tốc ban đầu (Vo)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chiều dài con lắc (l)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Góc ban đầu (α)";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnStart.Location = new System.Drawing.Point(46, 392);
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
            this.btnPause.Location = new System.Drawing.Point(141, 392);
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
            this.groupBox2.Controls.Add(this.lblT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblX);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtOmega);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAlphaNew);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(589, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 117);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá trị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Omega (ω)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alpha(α)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pi (π)";
            // 
            // txtOmega
            // 
            this.txtOmega.Enabled = false;
            this.txtOmega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtOmega.Location = new System.Drawing.Point(83, 81);
            this.txtOmega.Name = "txtOmega";
            this.txtOmega.Size = new System.Drawing.Size(132, 22);
            this.txtOmega.TabIndex = 2;
            this.txtOmega.Text = "0";
            // 
            // txtAlphaNew
            // 
            this.txtAlphaNew.Enabled = false;
            this.txtAlphaNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAlphaNew.Location = new System.Drawing.Point(83, 55);
            this.txtAlphaNew.Name = "txtAlphaNew";
            this.txtAlphaNew.Size = new System.Drawing.Size(132, 22);
            this.txtAlphaNew.TabIndex = 3;
            this.txtAlphaNew.Text = "0";
            // 
            // txtPi
            // 
            this.txtPi.Enabled = false;
            this.txtPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPi.Location = new System.Drawing.Point(83, 29);
            this.txtPi.Name = "txtPi";
            this.txtPi.Size = new System.Drawing.Size(132, 22);
            this.txtPi.TabIndex = 4;
            this.txtPi.Text = "0";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(224, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "(t) : ";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblT.ForeColor = System.Drawing.Color.Blue;
            this.lblT.Location = new System.Drawing.Point(253, 86);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 16);
            this.lblT.TabIndex = 5;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVo;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtAlpa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox Paper;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOmega;
        private System.Windows.Forms.TextBox txtAlphaNew;
        private System.Windows.Forms.TextBox txtPi;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label label9;
    }
}

