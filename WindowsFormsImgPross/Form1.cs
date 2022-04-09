using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsImgPross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgFile = new OpenFileDialog();
            imgFile.Filter = "Image File (*.bmp,*.jpg,*.png,*.gif)|*.bmp;*.jpg;*.png;*.gif";
            if (DialogResult.OK == imgFile.ShowDialog())
            {
                this.pictureImp.Image = new Bitmap(imgFile.FileName);
                this.pictureImp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap copy = new Bitmap((Bitmap)this.pictureImp.Image);
                float[,] matrix = Converting.ConvertToMatrix(copy);
                for (int i = 0; i < copy.Width; i++) {
                    this.txtMatrix.Text = this.txtMatrix.Text + Environment.NewLine;
                    for (int j = 0; j < copy.Height; j++)
                    {
                        this.txtMatrix.Text = this.txtMatrix.Text + matrix[i, j].ToString("0.00") +"|  ";
                    }
                    this.txtMatrix.Text = this.txtMatrix.Text + Environment.NewLine + "__________________________________________________________________________________";

                }

            }
            catch(Exception ex)
            {
                this.txtMatrix.Text = ex.ToString();
            }
        }
    }
}
