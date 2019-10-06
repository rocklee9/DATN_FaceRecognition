using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaceRecognition
{
    public partial class MainForm : Form
    {
        Image<Bgr, Byte> currentFrame;
        VideoCapture grabber;
        CascadeClassifier face;
        //MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;





        string name, names = null;
        public MainForm()
        {
            InitializeComponent();

            face = new CascadeClassifier(@"../../Data/haarcascade_frontalface_default.xml");

            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new VideoCapture();
            grabber.QueryFrame();
            
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            btnStart.Enabled = false;
        }

        void FrameGrabber(object sender, EventArgs e)
        {


            //Get the current frame form capture device
            using (var imageFrame = grabber.QueryFrame().ToImage<Bgr, byte>())
            {
                if (imageFrame != null)
                {
                    //Convert it to Grayscale
                    gray = imageFrame.Convert<Gray, byte>();
                    //Face Detector
                    var facesDetected = face.DetectMultiScale(
                  gray,
                  1.1,
                  10,
                  Size.Empty);

                    //Action for each element detected
                    foreach (var f in facesDetected)
                    {
                        //  t = t + 1;
                        // result = currentFrame.Copy(f).Convert<Gray, byte>().Resize(100, 100, Inter.Cubic);
                        //draw the face detected in the 0th (gray) channel with blue color
                        imageFrame.Draw(f, new Bgr(Color.Red), 3);


                        //if (trainingImages.ToArray().Length != 0)
                        //{
                        //    //TermCriteria for face recognition with numbers of trained images like maxIteration
                        //    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                        //    //Eigen face recognizer
                        //    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                        //       trainingImages.ToArray(),
                        //       labels.ToArray(),
                        //       3000,
                        //       ref termCrit);

                        //    name = recognizer.Recognize(result);

                        //    //Draw the label for each face detected and recognized
                        //    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                        //}

                        //NamePersons[t - 1] = name;
                        //NamePersons.Add("");




                    }
                    t = 0;

                    //Names concatenation of persons recognized
                    //for (int nnn = 0; nnn < facesDetected.Length; nnn++)
                    //{
                    //    names = names + NamePersons[nnn] + ", ";
                    //}

                   
                }
                //Show the faces procesed and recognized
                imgCamera.Image = imageFrame.ToBitmap();

                //Clear the list(vector) of names
                NamePersons.Clear();

            }

                
                

            

            
            

        }
    }
}
