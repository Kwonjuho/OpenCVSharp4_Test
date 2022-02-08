using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace OpenCV
{
    public partial class Convertf : Form
    {
        Resize f;

        public Convertf()
        {
            InitializeComponent();
        }

        private void Convert_Load(object sender, EventArgs e)
        {

        }

        Mat src = new Mat();
        Mat dst = new Mat();
        Mat binary = new Mat();
        Mat gray = new Mat();

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

        public void ShowFileSaveDialog()
        {
            saveFileDialog.Title = "이미지 저장";
            saveFileDialog.Filter = 
                "bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png|tiff (*.tiff)|*.tiff";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileName = saveFileDialog.FileName;
                    Cv2.ImWrite(FileName, src);
                    Cv2.ImWrite(FileName, dst);
                    Cv2.ImWrite(FileName, binary);
                }
                catch { }
            }
        }

        //* 그레이스케일 버튼
        private void btnGrayscale_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    src = new Mat(FileName, ImreadModes.Grayscale);
                    pbImg2.ImageIpl = src;
                    pbImg2.SizeMode = PictureBoxSizeMode.Zoom;
                    Cv2.WaitKey(0);
                }
                catch { }
            }
        }

        // * 3채널 BGR 이미지 버튼
        private void btn3ChColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    src = new Mat(FileName, ImreadModes.Color);
                    pbImg2.ImageIpl = src;
                    pbImg2.SizeMode = PictureBoxSizeMode.Zoom;
                    Cv2.WaitKey(0);
                }
                catch { }
            }
        }

        //* 대칭 버튼
        private void btnSymmetry_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    src = Cv2.ImRead(FileName);
                    dst = new Mat(src.Size(), MatType.CV_8UC3);

                    Cv2.Flip(src, dst, FlipMode.Y);                                 // * X : 상하대칭 Y : 좌우 대칭, XY : 상하좌우 대칭
                    pbImg2.ImageIpl = dst;
                    pbImg2.SizeMode = PictureBoxSizeMode.Zoom;
                    Cv2.WaitKey(0);
                }
                catch { }
            }
        }

        // * 스케일 업 버튼
        private void btnScaleUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    src = Cv2.ImRead(FileName);
                    dst = new Mat();
                    Cv2.PyrUp(src, dst);
                    pbImg2.ImageIpl = dst;
                    pbImg2.SizeMode = PictureBoxSizeMode.Normal;
                    Cv2.WaitKey(0);
                }
                catch { }
            }
        }

        // * 스케일 다운 버튼
        private void btnScaleDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    src = Cv2.ImRead(FileName);
                    dst = new Mat();
                    Cv2.PyrDown(src, dst);
                    pbImg2.ImageIpl = dst;
                    pbImg2.SizeMode = PictureBoxSizeMode.Normal;
                    Cv2.WaitKey(0);
                }
                catch { }
            }
        }

        // * 리사이즈 세팅 버튼
        private void btnResizeSet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                f = new Resize(this);
                f.Show();
            }
        }

        // * 리사이즈 버튼
        private void btnResize_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int Width = Convert.ToInt32(pub.shreadA);
                int Height = Convert.ToInt32(pub.shreadB);

                try
                {
                    src = Cv2.ImRead(FileName);
                    dst = new Mat();
                    Cv2.Resize(src, dst, new OpenCvSharp.Size(Width, Height));
                    pbImg2.ImageIpl = dst;
                    pbImg2.SizeMode = PictureBoxSizeMode.Normal;
                    Cv2.WaitKey(0);
                }
                catch { }
            }
        }

        // * 자르기 버튼
        private void btnCut_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    src = new Mat(FileName);
                    dst = src.SubMat(new Rect(150, 150, 150, 150));
                    pbImg2.ImageIpl = dst;
                    pbImg2.SizeMode = PictureBoxSizeMode.Normal;
                    Cv2.WaitKey(0);
                }
                catch { }
            }
        }

        // * 이진화 버튼
        private void btnBinarization_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    src = new Mat(FileName);
                    gray = new Mat();
                    binary = new Mat();
                    Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
                    Cv2.Threshold(gray, binary, 150, 255, ThresholdTypes.Binary);
                    pbImg2.ImageIpl = binary;
                    pbImg2.SizeMode = PictureBoxSizeMode.Zoom;
                    Cv2.WaitKey(0);
                }
                catch { }
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

        // * 저장하기 버튼
        private void btnFileSave_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowFileSaveDialog();
            }
        }
    }
    public class pub
    {
        public static int shreadA;
        public static int shreadB;
    }
}
