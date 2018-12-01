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
        Single vo, t;
        Single x, y;
        double alpha;
        int k = 40;
        double l;
        float Omega;
        float phi;
        bool flag = false;


        private void btnStart_Click(object sender, EventArgs e)
        {
            //init Data 

            vo = float.Parse(txtVo.Text.Trim());
            l = double.Parse(txtLength.Text.Trim());
            Omega = (float)Math.Sqrt(9.8 / float.Parse(txtLength.Text));
            phi = (float)Math.Atan(-vo / (alpha * l * Omega));
            alpha = Math.PI * float.Parse(txtAlpa.Text) / 180;
            x = w / 2 - (float)(l * Math.Sin(alpha));
            y = k + (float)(l * Math.Cos(alpha));


            btnPause.Enabled = true;
            btnStart.Enabled = false;

            flag = true;

            //Cos(phi) = alpha/alpha0 < 1
            //Sin(phi) = vo/alpha0 < l*Omega
            //
            if (vo / (float.Parse(txtAlpa.Text) * Math.PI / 180) < l * Omega)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Điều kiện ban đầu không hợp lệ!. Đề nghị kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            w = Paper.Width;
            h = Paper.Height;
            x = k;
            y = h - k;
            btnPause.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += float.Parse("0.1");
            //Cập nhất lại alpha theo t
            alpha = Math.PI * double.Parse(txtAlpa.Text.Trim()) * Math.Cos(Omega * t + phi) / 180;

            //Dùng động năng xác định vị trí x,y
            x = w / 2 - (float)(l * Math.Sin(alpha));
            y = k + (float)(l * Math.Cos(alpha));
            Paper.Invalidate();

            txtAlphaNew.Text = alpha.ToString();
            txtOmega.Text = Omega.ToString();
            txtPi.Text = phi.ToString();
            lblX.Text = x.ToString();
            lblY.Text = y.ToString();
            lblT.Text = t.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Enabled = true;
            btnPause.Enabled = false;
        }

        public frmMain()
        {
            InitializeComponent();
        }

      
        private void Paper_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (flag)
            {
                e.Graphics.DrawLine(Pens.Black, new Point(w / 2 - 50, k), new Point(w / 2 + 50, k));
                e.Graphics.DrawLine(Pens.Black, new Point((int)x, (int)y), new Point(w / 2, k));
                
                e.Graphics.DrawLine(Pens.Black, new Point(w / 2, (int)l), new Point(w / 2, k));


             //  e.Graphics.DrawEllipse(Pens.Blue, new RectangleF(x - 5, y - 5, 10, 10));
               e.Graphics.FillEllipse(Brushes.Blue, new RectangleF(x - 5, y - 5, 10, 10));
            }
           
        }
    }
}
