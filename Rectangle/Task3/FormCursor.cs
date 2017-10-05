using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class FormCursor : Form
    {
        public FormCursor()
        {
            InitializeComponent();
        }

        private void FormCursor_MouseMove(object sender, MouseEventArgs cursor)
        {
            Text = cursor.Location.ToString();
        }
    }
}
