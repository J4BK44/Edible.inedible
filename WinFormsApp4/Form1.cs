using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        Image[] imgeat = new Image[9];
        Image[] imgat = new Image[9];
        int i = 0;
        int k = 60;

        int tempCard1, tempCard2;

        public Form1()
        { 
            InitializeComponent();
            imgat[0] = Image.FromFile(@"c:\pictures\1.jpg");
            imgat[1] = Image.FromFile(@"c:\pictures\3.jpg");
            imgat[2] = Image.FromFile(@"c:\pictures\5.jpg");
            imgat[3] = Image.FromFile(@"c:\pictures\7.jpg");
            imgat[4] = Image.FromFile(@"c:\pictures\9.jpg");
            imgat[5] = Image.FromFile(@"c:\pictures\11.jpg");
            imgat[6] = Image.FromFile(@"c:\pictures\13.jpg");
            imgat[7] = Image.FromFile(@"c:\pictures\15.jpg");
            imgat[8] = Image.FromFile(@"c:\pictures\17.jpg");
            imgeat[0] = Image.FromFile(@"c:\pictures\2.jpg");
            imgeat[1] = Image.FromFile(@"c:\pictures\4.jpg");
            imgeat[2] = Image.FromFile(@"c:\pictures\6.jpg");
            imgeat[3] = Image.FromFile(@"c:\pictures\8.jpg");
            imgeat[4] = Image.FromFile(@"c:\pictures\10.jpg");
            imgeat[5] = Image.FromFile(@"c:\pictures\12.jpg");
            imgeat[6] = Image.FromFile(@"c:\pictures\14.jpg");
            imgeat[7] = Image.FromFile(@"c:\pictures\16.jpg");
            imgeat[8] = Image.FromFile(@"c:\pictures\18.jpg");
        }


        

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            Random rand = new Random();
            tempCard1 = rand.Next(0, 9);
            tempCard2 = rand.Next(0, 9);
           
            pictureBox1.Image = imgat[tempCard1];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = imgeat[tempCard2];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            button1.Visible = true;
            button3.Visible = false;
        }

    private void pictureBox1_Click(object sender, EventArgs e)
        {
            


            if (pictureBox1.Image == imgat[tempCard1])
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                timer1.Enabled = false;
                button1.Enabled = false;
                MessageBox.Show("Вы проиграли! Ваш счет = " + i);
            }
            else
            {
                i++;
                label1.Text = "Ваш счет = " + i;

                Random rand = new Random();
                tempCard1 = rand.Next(0, 9);
                tempCard2 = rand.Next(0, 9);
                pictureBox1.Image = imgat[tempCard1];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = imgeat[tempCard2];
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

            if (pictureBox2.Image == imgat[tempCard1])
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                timer1.Enabled = false;
                button1.Enabled = false;
                MessageBox.Show("Вы проиграли! Ваш счет = " + i);
            }
            else
            {
                i++;
                label1.Text = "Ваш счет = " + i;

                Random rand = new Random();
                tempCard1 = rand.Next(0, 9);
                tempCard2 = rand.Next(0, 9);
                pictureBox1.Image = imgeat[tempCard2];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = imgat[tempCard1];
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult dialogResult = MessageBox.Show("Вы уверены завершить игру?", "Предупреждение!", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                timer1.Enabled = false;
                button1.Enabled = false;
                MessageBox.Show("Вы завершили игру! Ваш счет = " + i);
            }
            else 
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k--;
            label2.Text = k.ToString();
            if (k == 0)
            {
                timer1.Stop();
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                timer1.Enabled = false;
                button1.Enabled = false;
                MessageBox.Show("Время закончено! Ваш счет = " + i);
            }

        }

    }
}
