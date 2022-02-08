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
using OpenCvSharp.XFeatures2D;

namespace OpenCV
{
    public partial class Matches : Form
    {
        public Matches()
        {
            InitializeComponent();
        }

        private void Matches_Load(object sender, EventArgs e)
        {

        }

        private void btnMatches_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // * 바탕화면 경로

                // * 전체이미지에서 비교할 부분이미지를 사각형으로 추출한다.
                // * 이미지 원본
                var img1 = new Mat(desktopPath + "./3.bmp", ImreadModes.AnyDepth);
                Mat dst = new Mat();
                Cv2.WaitKey(1); // do events
                Cv2.Resize(img1, dst, new OpenCvSharp.Size(500, 500));

                var img2 = new Mat(desktopPath + "./5.bmp", ImreadModes.AnyDepth);
                Mat dst2 = new Mat();
                Cv2.Resize(img2, dst2, new OpenCvSharp.Size(500, 500));
                Cv2.WaitKey(1);                                                                     // * 1초 후 다음 이벤트

                // * 키포인트 검출
                var Detector = SURF.Create(hessianThreshold: 500);                                  // * 기본값 300 ~ 500
                var keypoints1 = Detector.Detect(dst);
                var keypoints2 = Detector.Detect(dst2);
                var extractor = BriefDescriptorExtractor.Create();
                var Descriptors1 = new Mat();
                var Descriptors2 = new Mat();

                extractor.Compute(dst, ref keypoints1, Descriptors1);
                extractor.Compute(dst2, ref keypoints2, Descriptors2);

                var matcher = new BFMatcher();
                var matches = matcher.Match(Descriptors1, Descriptors2);

                // * 결과 그리기
                var imgMatches = new Mat();

                Cv2.DrawMatches(dst, keypoints1, dst2, keypoints2, matches, imgMatches);
                Cv2.ImShow("유사도검출 결과", imgMatches);                                         // * 결과 창

                double number_keypoints = 0;
                double number_keypoints2 = 0;

                if (keypoints1.Length <= keypoints2.Length)
                {
                    number_keypoints = keypoints1.Length;
                    number_keypoints2 = keypoints2.Length;
                }
                
                else
                {
                    number_keypoints = keypoints2.Length;
                    number_keypoints2 = keypoints1.Length;
                }

                txtKeyPoint1.Text = Convert.ToString("원본이미지 키포인트: " + keypoints1.Length);
                txtKeyPoint2.Text = Convert.ToString("대상이미지 키포인트: " + keypoints2.Length);
                txtScore.Text = Convert.ToString("Score : " + (double)number_keypoints / number_keypoints2);

                Cv2.WaitKey(1);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
                dst.Dispose();
                dst2.Dispose();
            }
        }
    }
}
