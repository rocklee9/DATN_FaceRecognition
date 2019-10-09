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
        Image<Gray, byte> result=null;
        Image<Gray, byte> TrainedFace ;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
        Rectangle [] facesDetected =new Rectangle[10];

        private void BtnAddFace_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the current frame form capture device
                using (var imageFrame = grabber.QueryFrame().ToImage<Bgr, byte>())
                {
                    if (imageFrame != null)
                    {
                        //Convert it to Grayscale
                        gray = imageFrame.Convert<Gray, byte>();
                        //Face Detector
                        facesDetected = face.DetectMultiScale(
                      gray,
                      1.2,
                      10,
                      Size.Empty);

                        //Action for each element detected
                        foreach (var f in facesDetected)
                        {
                            

                            TrainedFace = currentFrame.Copy(f).Convert<Gray, byte>();
                            //CvInvoke.CvtColor(currentFrame.Copy(facesDetected[0]), TrainedFace, typeof(Bgr), typeof(Gray));

                            break;

                        }

                        //resize face detected image for force to compare the same size with the 
                        //test image with cubic interpolation type method
                        TrainedFace = result.Resize(150, 150, Emgu.CV.CvEnum.Inter.Cubic);
                        trainingImages.Add(TrainedFace);
                        labels.Add(txtNameTraining.Text);

                        //Show face added in gray scale
                        picTraining.Image = TrainedFace.ToBitmap();

                        //Write the number of triained faces in a file text for further load
                       // File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                        //Write the labels of triained faces in a file text for further load
                        //for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                        //{
                        //    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                        //    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                        //}

                        //MessageBox.Show(txtNameTraining.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                        

                

                

                
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
                //MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public MainForm()
        {
            InitializeComponent();

            face = new CascadeClassifier(@"../../Data/haarcascade_frontalface_default.xml");

            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(@"../../TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(@"../../TrainedFaces/" + LoadFaces));
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
                    currentFrame = grabber.QueryFrame().ToImage<Bgr, byte>();
                    //Convert it to Grayscale
                    gray = imageFrame.Convert<Gray, byte>();
                    //Face Detector
                    facesDetected = face.DetectMultiScale(
                  gray,
                  1.1,
                  10,
                  Size.Empty);

                    //Action for each element detected
                    foreach (Rectangle f in facesDetected)
                    {
                        //  t = t + 1;
                        result = currentFrame.Copy(f).Convert<Gray, byte>().Resize(100, 100, Inter.Cubic);
                        //draw the face detected in the 0th (gray) channel with blue color
                        imageFrame.Draw(f, new Bgr(Color.Red), 2);


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
