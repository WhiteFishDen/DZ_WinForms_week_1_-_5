using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_WinForms_week_1___5
{
    public partial class Form1 : Form
    {
        Label _static;
        public Form1()
        {
            InitializeComponent();
            Text = "Running static";
            _static = new Label();
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.X>_static.Location.X - 40 && e.X < _static.Location.X + _static.Width + 40)&&
               (e.Y>_static.Location.Y - 40 && e.Y<_static.Location.Y+_static.Height + 40 ))
            {
                if(e.X >_static.Location.X - 40 && e.X < _static.Location.X)
                {
                    _static.Left += 20;
                }
                else if(e.X<_static.Location.X + _static.Width &&e.X>_static.Location.X)
                {
                    _static.Left -= 20;
                }
                else if(e.Y>_static.Location.Y -40 && e.Y<_static.Location.Y)
                {
                    _static.Top += 20;
                }
                else if(e.Y<_static.Location.Y+_static.Height&&e.Y>_static.Location.Y)
                {
                    _static.Top -= 20;
                }
                if((_static.Location.X<0||_static.Location.X>ClientSize.Width - _static.Width)||
                    (_static.Location.Y<0||_static.Location.Y>ClientSize.Height-_static.Height))
                {
                    StaticCenter(_static);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _static.Text = "Catch Me if you can!";
            _static.Size = new Size(100, 80);
            _static.BackColor = Color.YellowGreen;
            _static.ForeColor = Color.Red;
            _static.AutoSize = false;
            _static.BorderStyle = BorderStyle.Fixed3D;
            _static.TextAlign = ContentAlignment.MiddleCenter;
            _static.Location = new Point(this.Width/2,this.Height/2);
            Controls.Add(_static);
            StaticCenter(_static);
        }
        void StaticCenter(Label _static)
        {
            _static.Left = (ClientSize.Width-_static.Width)/2;
            _static.Top = (ClientSize.Height - _static.Height) / 2;
        }
    }
}
