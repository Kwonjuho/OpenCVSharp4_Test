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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Home homeForm = new Home();
        Cam camForm = new Cam();
        Matches matchesForm = new Matches();
        Convertf convertForm = new Convertf();
        Bitwise bitwiseForm = new Bitwise();
        Edge edgeForm = new Edge();

        private void Main_Load(object sender, EventArgs e)
        {
            homeForm.TopLevel = false;
            homeForm.Parent = this.pnForm;
            homeForm.ControlBox = false;
            homeForm.Show();

            camForm.TopLevel = false;
            camForm.Parent = this.pnForm;
            camForm.ControlBox = false;

            matchesForm.TopLevel = false;
            matchesForm.Parent = this.pnForm;
            matchesForm.ControlBox = false;

            convertForm.TopLevel = false;
            convertForm.Parent = this.pnForm;
            convertForm.ControlBox = false;

            bitwiseForm.TopLevel = false;
            bitwiseForm.Parent = this.pnForm;
            bitwiseForm.ControlBox = false;

            edgeForm.TopLevel = false;
            edgeForm.Parent = this.pnForm;
            edgeForm.ControlBox = false;
        }

        // * 캠 버튼
        private void btnCam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                camForm.Show();
                homeForm.Hide();
                matchesForm.Hide();
                convertForm.Hide();
                bitwiseForm.Hide();
                edgeForm.Hide();
            }
        }

        // * 유사도 버튼
        private void btnMatches_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                matchesForm.Show();
                camForm.Hide();
                homeForm.Hide();
                convertForm.Hide();
                bitwiseForm.Hide();
                edgeForm.Hide();
            }
        }

        // * 색상공간 변환 버튼
        private void btnConvert_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                convertForm.Show();
                matchesForm.Hide();
                camForm.Hide();
                homeForm.Hide();
                bitwiseForm.Hide();
                edgeForm.Hide();
            }
        }

        // * 비트연산 버튼
        private void convertToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bitwiseForm.Show();
                convertForm.Hide();
                matchesForm.Hide();
                camForm.Hide();
                homeForm.Hide();
                edgeForm.Hide();
            }
        }

        // * 윤곽선 검출 버튼
        private void btnEdge_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                edgeForm.Show();
                bitwiseForm.Hide();
                convertForm.Hide();
                matchesForm.Hide();
                camForm.Hide();
                homeForm.Hide();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
    }
}
