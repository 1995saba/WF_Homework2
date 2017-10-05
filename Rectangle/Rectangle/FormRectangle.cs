using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle
{
    public partial class FormRectangle : Form
    {
        public FormRectangle()
        {
            InitializeComponent();
        }

        private void FormRectangle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                label.Text = "Курсор снаружи";

                if (Control.ModifierKeys == Keys.Control)
                {
                    Close();
                }
            }
            if (e.Button.ToString() == "Right")
            {
                Text = "Ширина = " + this.Width.ToString() +
                    ", высота = " + this.Height.ToString();
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                label.Text = "Курсор внутри прямоугольника";

                if (Control.ModifierKeys == Keys.Control)
                {
                    Close();
                }
            }
            if (e.Button.ToString() == "Right")
            {
                Text = "Ширина = " + this.Width.ToString() +
                    ", высота = " + this.Height.ToString();
            }
        }
    }
}
