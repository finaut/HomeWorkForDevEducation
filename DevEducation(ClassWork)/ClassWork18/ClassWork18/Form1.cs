using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ClassWork18
{
    public partial class mainDrawingSurface : Form
    {
        Bitmap _bitmap;
        Pen _pen;
        Graphics _graphics;
        int x1, y1;
        
        public mainDrawingSurface()
        {
            InitializeComponent();
            x1 = y1 = 0;
        }
        private void mainDrawingSurface_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(mainPicture.Width, mainPicture.Height);
            _pen = new Pen(Color.Green, 8);
            _graphics = Graphics.FromImage(_bitmap);
            //_graphics.DrawLine(_pen, 10, 10, 300, 10);
            //_graphics.DrawRectangle(_pen, 10, 50, 300, 100);
            //_graphics.DrawEllipse(_pen, 10, 200, 100, 100);
            //_graphics.DrawEllipse(_pen, 300, 200, 100, 200);

            //Point A = new Point(150, 200);
            //Point B = new Point(300, 300);
            
            mainPicture.Image = _bitmap;


        }

        private void mainPicture_MouseMove(object sender, MouseEventArgs e)
        {
            _pen.StartCap = LineCap.Round;
            _pen.EndCap = LineCap.Round;
            if(e.Button == MouseButtons.Left)
            {
                _graphics.DrawLine(_pen, x1, y1, e.X, e.Y);
                mainPicture.Image = _bitmap;
            }
            x1 = e.X;
            y1 = e.Y;
        }
        private void mainPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                _graphics.FillRectangle(Brushes.Blue, e.X, e.Y, 10, 10);
                mainPicture.Image = _bitmap;

            }
        }
    }
}
