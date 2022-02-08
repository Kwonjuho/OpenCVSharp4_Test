using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using System.Collections.Generic;
using OpenCvSharp;

namespace OpenCV
{
    public partial class Edge : Form
    {
        public Edge()
        {
            InitializeComponent();
        }

        private void Edge_Load(object sender, EventArgs e)
        {

        }

        Image image;
        string FileName;

        public void ShowFileOpenDialog()
        {
            openFileDialog.Title = "이미지 읽기";
            openFileDialog.Filter =
                "모든 그림 파일(*.*)|*.*|bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png|tiff (*.tiff)|*.tiff";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                image = Image.FromFile(FileName);
                pbImg.Image = image;
                pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        Mat src = new Mat();

        private void btnEdge_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                src = new Mat(FileName, ImreadModes.AnyColor);
                Mat blur = new Mat();

                Mat sobel = new Mat();
                Mat scharr = new Mat();
                Mat laplacian = new Mat();
                Mat canny = new Mat();

                Cv2.GaussianBlur(src, blur, new OpenCvSharp.Size(3, 3), 1, 0, BorderTypes.Default);

                Cv2.Sobel(blur, sobel, MatType.CV_32F, 1, 0, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
                sobel.ConvertTo(sobel, MatType.CV_8UC1);

                Cv2.Scharr(blur, scharr, MatType.CV_32F, 1, 0, scale: 1, delta: 0, BorderTypes.Default);
                scharr.ConvertTo(scharr, MatType.CV_8UC1);

                Cv2.Laplacian(blur, laplacian, MatType.CV_32F, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
                laplacian.ConvertTo(laplacian, MatType.CV_8UC1);

                Cv2.Canny(blur, canny, 100, 200, 3, true);

                Cv2.ImShow("sobel", sobel);
                Cv2.ImShow("scharr", scharr);
                Cv2.ImShow("laplacian", laplacian);
                Cv2.ImShow("canny", canny);
                Cv2.WaitKey(0);
            }
        }

        // * 불러오기 버튼
        private void btnFileOpen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowFileOpenDialog();
            }
        }
    }
}
