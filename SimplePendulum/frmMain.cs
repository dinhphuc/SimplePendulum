using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePendulum
{
   
    public partial class frmMain : Form
    {
        int w, h;
        Single x, y;
        int k = 40;

        private Pendulum pendulum = new Pendulum();

        private bool hasForce;
        private bool startAnimation;

        private float force;
        //private float M;
        private bool isRight;
        private void btnStart_Click(object sender, EventArgs e)
        {
            hasForce = true;
            //init Data 
            if ( nudForceValue.Value != 0)
            {
                if (cmbDirection.SelectedItem.ToString() == "Left")
                {
                    isRight = false;
                }
                else
                {
                    isRight = true;
                }
                pendulum.M = (float)nudM.Value;
                force = (float)nudForceValue.Value / 1000;
                startAnimation = true;
                timer1.Start();
                btnStart.Enabled = false;
                btnPause.Enabled = true;
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            w = Paper.Width;
            h = Paper.Height;
            x = k;
            y = h - k;
            btnPause.Enabled = false;

            pendulum.Alpha = 0;
            pendulum.aVel = 0;
            pendulum.aAcc = 0;

            pendulum.origin = new Point(Paper.Width / 2, Paper.Height / 4);
            pendulum.radius = 5;
            pendulum.lenght = (int)nudLenght.Value;
            btnPause.Enabled = false;
            btnStart.Enabled = true;

            cmbDirection.Text = "Right";

            DrawPendulum();
        }
        private void DrawPendulum()
        {
            //1. tạo một bitmap mới 
            Bitmap bm = new Bitmap(Paper.Width, Paper.Height);
            Graphics g = Graphics.FromImage(bm);

            txtAlphaNew.Text = pendulum.Alpha.ToString();
            lblX.Text = pendulum.ballPos.X.ToString();
            lblY.Text = pendulum.ballPos.Y.ToString();
            //2. xóa màn hình
            g.Clear(Color.White);

            //3. vẽ
            pendulum.DrawPendulum(g);
            Paper.Image = bm;

            //4. dispose
            g.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (startAnimation)
            {
                startRunning();
            }
        }

        private void startRunning()
        {
            if (hasForce)
            {
                //công thức gia tốc góc (acceleration)
                pendulum.aAcc = (float)(force * Math.Cos(Math.Abs(pendulum.Alpha)) / pendulum.M)
                    - (float)(0.01 * Math.Sin(Math.Abs(pendulum.Alpha)));

                if (isRight == false)   //hướng lực là trái
                {
                    pendulum.Alpha -= pendulum.aVel;
                }
                else
                {
                    pendulum.Alpha += pendulum.aVel;      //hướng lực là phải
                }
                pendulum.aVel += pendulum.aAcc;

                if (pendulum.aVel <= 0)
                {
                    hasForce = false;
                    pendulum.aVel = 0;
                }
            }
            else
            {
                //Sau khi lực tac dụng
                pendulum.aAcc = (float)(-0.01 * Math.Sin(pendulum.Alpha));
                pendulum.Alpha += pendulum.aVel;
                pendulum.aVel += pendulum.aAcc;

                //giảm xóc
                pendulum.aVel *= 0.99f;
            }

            DrawPendulum();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            frmMain_Load(sender, e);
        }

        public frmMain()
        {
            InitializeComponent();
        }        
    }
}
