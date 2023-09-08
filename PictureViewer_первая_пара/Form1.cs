using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer_первая_пара
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Show the Open File dialog. If the user clicks OK, load the
                // picture that the user chose.
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Show the Open File dialog. If the user clicks OK, load the
                // picture that the user chose.
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void рисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void растянутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (a == 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                a = 1;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                a = 0;
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void растянутьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
        }

        private void выбратьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Show the Open File dialog. If the user clicks OK, load the
                // picture that the user chose.
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
    }
}
