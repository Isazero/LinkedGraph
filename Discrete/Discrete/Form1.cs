using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discrete
{
    public partial class Form1 : Form
    {
        public int[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        { 
            int vertices = Convert.ToInt32(comboBox2.Text);
            matrix = new int[vertices,vertices];
            ShowAdjencyMatrix(vertices);
        }

        private void ShowAdjencyMatrix(int vertices)
        {
            label2.Show();
            var textBoxes = new[]
            {
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6,
                textBox7,
                textBox8,
                textBox9,
                textBox10,
                textBox11,
                textBox12,
                textBox13,
                textBox14,
                textBox15,
                textBox16,
                textBox17,
                textBox18,
                textBox19,
                textBox20,
                textBox21,
                textBox22,
                textBox23,
                textBox24,
                textBox25
            };
            switch (vertices)
            {
                case 2:
                    

                    foreach (var box in textBoxes)
                    {
                        if (box == textBox1 || box == textBox2
                                            || box == textBox9 || box == textBox10)
                        {
                            box.Show();
                            
                        }
                        else
                        {
                            box.Hide();
                        }
                    }

                    break;
                case 3:
                    foreach (var box in textBoxes)
                    {
                        if (box == textBox1 || box == textBox2 || box == textBox3
                            || box == textBox9 || box == textBox10 || box == textBox8
                            || box == textBox15 || box == textBox14 || box == textBox13)
                        {
                            box.Show();
                        }
                        else
                        {
                            box.Hide();
                        }
                    }

                    break;
                case 4:
                    foreach (var box in textBoxes)
                    {
                        if (box == textBox1 || box == textBox2 || box == textBox3 || box == textBox4
                            || box == textBox9 || box == textBox10 || box == textBox8 || box == textBox7
                            || box == textBox15 || box == textBox14 || box == textBox13 || box == textBox12
                            || box == textBox20 || box == textBox19 || box == textBox18 || box == textBox17)
                        {
                            box.Show();
                        }
                        else
                        {
                            box.Hide();
                        }
                    }

                    break;
                case 5:
                    foreach (var box
                        in textBoxes)
                    {
                        box.Show();
                    }

                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                matrix[0, 0] = Convert.ToInt32(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                matrix[0, 1] = Convert.ToInt32(textBox1.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                matrix[0, 2] = Convert.ToInt32(textBox1.Text);
            }
        }

        private void insertZero(object sender, EventArgs e)
        {
            sender = "0";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
