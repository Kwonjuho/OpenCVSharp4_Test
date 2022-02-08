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

namespace OpenCV
{
    public partial class Bitwise : Form
    {
        public Bitwise()
        {
            InitializeComponent();
        }

        private void Bitwise_Load(object sender, EventArgs e)
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
                pbImg1.Image = image;
                pbImg1.SizeMode = PictureBoxSizeMode.Zoom;
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

        Mat and = new Mat();
        Mat or = new Mat();
        Mat xor = new Mat();
        Mat not = new Mat();
        Mat compare = new Mat();

        // * 비트연산 버튼
        private void btnBitwise_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Mat src1 = new Mat(FileName, ImreadModes.ReducedColor2);
                Mat src2 = src1.Flip(FlipMode.Y);

                and = new Mat();
                or = new Mat();
                xor = new Mat();
                not = new Mat();
                compare = new Mat();

                Cv2.BitwiseAnd(src1, src2, and);
                Cv2.BitwiseOr(src1, src2, or);
                Cv2.BitwiseXor(src1, src2, xor);
                Cv2.BitwiseNot(src1, not);
                Cv2.Compare(src1, src2, compare, CmpType.LT); /*  CmpTypes.EQ src1과 src2의 요소가 같음
                                                                  CmpTypes.GT src1이 src2보다 요소가 큼
                                                                  CmpTypes.GE src1이 src2보다 요소가 크거나 같음
                                                                  CmpTypes.LT src1이 src2보다 요소가 작음
                                                                  CmpTypes.LE src1이 src2보다 요소가 작거나 같음
                                                                  CmpTypes.NE src1과 src2의 요소가 같지 않음 */

                pbImgAND.ImageIpl = and;
                pbImgOR.ImageIpl = or;
                pbImgNOT.ImageIpl = not;
                pbImgXOR.ImageIpl = xor;
                pbImgCompare.ImageIpl = compare;
                Cv2.WaitKey(0);
            }
        }
    }
}
