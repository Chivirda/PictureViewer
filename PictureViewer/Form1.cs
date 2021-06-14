using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (CheckBox1.Checked)
            {
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            PictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } else
            {
                PictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
