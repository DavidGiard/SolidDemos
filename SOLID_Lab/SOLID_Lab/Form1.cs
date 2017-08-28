using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetPhotoButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\development\SOLID\SOLID_Lab\Photos\";
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            string fileToDisplay = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileToDisplay = openFileDialog.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                var photo = new Bitmap(fileToDisplay);
                pictureBox1.Image = (Image)photo;
                PhotoPathLabel.Text = fileToDisplay;
            }
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {

        }

        private void MakeCopyButton_Click(object sender, EventArgs e)
        {
            string photoPath = PhotoPathLabel.Text;
            if (photoPath.Trim() == "")
            {
                Photo.CopyPhoto(photoPath);
            }
        }

        private async void AnalyzePhotoButton_Click(object sender, EventArgs e)
        {
            string photoPath = PhotoPathLabel.Text;
            if (photoPath.Trim() == "")
            {
                AnalysisResultsLabel.Text = "No image";
            }
            else
            {
                string imageInfo = await Photo.AnalyzeImage(photoPath);
                AnalysisResultsLabel.Text = imageInfo;
            }
        }
    }
}
