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
    public partial class Cam : Form
    {
        public Cam()
        {
            InitializeComponent();
        }

        VideoCapture CAM;
        Mat frame = new Mat();

        private void Cam_Load(object sender, EventArgs e)
        {
            try
            {
                CAM = new VideoCapture(0);
                CAM.FrameWidth = 640;
                CAM.FrameHeight = 480;
            }
            catch
            {
                timerCam.Enabled = false;
            }
            while (Cv2.WaitKey(33) != 'q')
            {
                CAM.Read(frame);
                Cv2.ImShow("노트북 카메라",frame);
            }
            frame.Dispose();
            CAM.Release();
            Cv2.DestroyAllWindows();
        }
    }
}
