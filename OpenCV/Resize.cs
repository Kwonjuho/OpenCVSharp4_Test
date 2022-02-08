using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV
{
    public partial class Resize : Form
    {
        Convertf f = null;
        public Resize(Convertf frm)
        {
            InitializeComponent();
            f = frm;
        }

        private void Resize_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    pub.shreadA = Convert.ToInt32(txtHeight.Text);
                    pub.shreadB = Convert.ToInt32(txtWidth.Text);
                    this.Close();
                }
                catch { }
            }
        }
    }
}
