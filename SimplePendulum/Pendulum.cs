using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePendulum
{
    class Pendulum
    {
        /// <summary>
        /// Gốc điểm
        /// </summary>
        public Point origin { get; set; } 
        /// <summary>
        /// Vị trí điểm
        /// </summary>
        public Point ballPos { get; set; }
        /// <summary>
        /// Diểm
        /// </summary>
        public Point endLine { get; set; }
        /// <summary>
        /// độ dài con lắc
        /// </summary>
        public int lenght { get; set; }
        /// <summary>
        /// Khối lượng con lắc
        /// </summary>
        public float M { get; set; }
        /// <summary>
        /// bán kính con lắc
        /// </summary>
        public int radius { get; set; }
        /// <summary>
        /// Góc
        /// </summary>
        public float Alpha { get; set; }
        /// <summary>
        /// Gia tốc góc
        /// </summary>
        public float aAcc { get; set; }
        /// <summary>
        /// độ giảm
        /// </summary>
        public float aVel { get; set; }

        public Pendulum()
        {
            Alpha = 0;
            aVel = 0;
            aAcc = 0;
        }
        public void DrawPendulum(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            endLine = new Point(origin.X + (int)(lenght * Math.Sin(Alpha)),
                origin.Y + (int)(lenght * Math.Cos(Alpha)));
            ballPos = new Point(origin.X + (int)((lenght + radius) * Math.Sin(Alpha)),
                origin.Y + (int)((lenght + radius) * Math.Cos(Alpha)));

            g.DrawLine(new Pen(Color.Red), new Point(origin.X - 20, origin.Y),
                new Point(origin.X + 20, origin.Y));
            g.DrawLine(new Pen(Color.Black), origin, ballPos);
            g.FillEllipse(Brushes.Blue, new Rectangle(ballPos.X - radius,
                ballPos.Y - radius, radius * 2, radius * 2));
        }
    }
}
