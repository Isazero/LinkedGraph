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
        public int vertices;
        public int[,] matrix1;

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
            if (isNumber(comboBox2.Text) && Convert.ToInt32(comboBox2.Text) >= 2 &&
                Convert.ToInt32(comboBox2.Text) <= 5)
            {
                 vertices = Convert.ToInt32(comboBox2.Text);
                matrix1 = new int[vertices, vertices];
                ShowAdjencyMatrix1(vertices);
            }
            else
            {
                comboBox2.Text = "";
            }
        }


        private void ShowAdjencyMatrix1(int vertices)
        {
            label5.Show();

            #region textboxes

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

            #endregion

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
            if (isNumber(textBox1.Text))
            {
                matrix1[0, 0] = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox2.Text))
            {
                matrix1[0, 1] = Convert.ToInt32(textBox2.Text);
            }
            else
            {
                textBox2.Text = "";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox3.Text))
            {
                matrix1[0, 2] = Convert.ToInt32(textBox3.Text);
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox4.Text))
            {
                matrix1[0, 3] = Convert.ToInt32(textBox4.Text);
            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox5.Text))
            {
                matrix1[0, 4] = Convert.ToInt32(textBox5.Text);
            }
            else
            {
                textBox5.Text = "";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox10.Text))
            {
                matrix1[1, 0] = Convert.ToInt32(textBox10.Text);
            }
            else
            {
                textBox10.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox9.Text))
            {
                matrix1[1, 1] = Convert.ToInt32(textBox9.Text);
            }
            else
            {
                textBox9.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox8.Text))
            {
                matrix1[1, 2] = Convert.ToInt32(textBox8.Text);
            }
            else
            {
                textBox8.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox7.Text))
            {
                matrix1[1, 3] = Convert.ToInt32(textBox7.Text);
            }
            else
            {
                textBox7.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox6.Text))
            {
                matrix1[1, 4] = Convert.ToInt32(textBox6.Text);
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox11.Text))
            {
                matrix1[2, 4] = Convert.ToInt32(textBox11.Text);
            }
            else
            {
                textBox11.Text = "";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox12.Text))
            {
                matrix1[2, 3] = Convert.ToInt32(textBox12.Text);
            }
            else
            {
                textBox12.Text = "";
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox13.Text))
            {
                matrix1[2, 2] = Convert.ToInt32(textBox13.Text);
            }
            else
            {
                textBox13.Text = "";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox14.Text))
            {
                matrix1[2, 1] = Convert.ToInt32(textBox14.Text);
            }
            else
            {
                textBox14.Text = "";
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox15.Text))
            {
                matrix1[2, 0] = Convert.ToInt32(textBox15.Text);
            }
            else
            {
                textBox15.Text = "";
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox16.Text))
            {
                matrix1[3, 4] = Convert.ToInt32(textBox16.Text);
            }
            else
            {
                textBox16.Text = "";
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox17.Text))
            {
                matrix1[3, 3] = Convert.ToInt32(textBox17.Text);
            }
            else
            {
                textBox17.Text = "";
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox18.Text))
            {
                matrix1[3, 2] = Convert.ToInt32(textBox18.Text);
            }
            else
            {
                textBox18.Text = "";
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox19.Text))
            {
                matrix1[3, 1] = Convert.ToInt32(textBox19.Text);
            }
            else
            {
                textBox19.Text = "";
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox20.Text))
            {
                matrix1[3, 0] = Convert.ToInt32(textBox20.Text);
            }
            else
            {
                textBox20.Text = "";
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox21.Text))
            {
                matrix1[4, 4] = Convert.ToInt32(textBox21.Text);
            }
            else
            {
                textBox21.Text = "";
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox22.Text))
            {
                matrix1[4, 3] = Convert.ToInt32(textBox22.Text);
            }
            else
            {
                textBox22.Text = "";
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox23.Text))
            {
                matrix1[4, 2] = Convert.ToInt32(textBox23.Text);
            }
            else
            {
                textBox23.Text = "";
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox24.Text))
            {
                matrix1[4, 1] = Convert.ToInt32(textBox24.Text);
            }
            else
            {
                textBox24.Text = "";
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox25.Text))
            {
                matrix1[4, 0] = Convert.ToInt32(textBox25.Text);
            }
            else
            {
                textBox25.Text = "";
            }
        }

        private void clearMatrix(object sender, EventArgs e)
        {
            #region textBoxes

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

            #endregion

            foreach (var box in textBoxes)
            {
                box.Clear();
            }
        }

       
        private void analyze(object sender, EventArgs e)
        {
            #region textBoxes

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

            #endregion
            int[] check = new int[vertices];
            Queue<int> queue = new Queue<int>();
            foreach (var box in textBoxes)
            {
                if (box.Visible && box.Text.Equals(""))
                {
                    MessageBox.Show("One of the TextBoxes is empty");
                    return;
                }
            }

            check[0] = 1;
            queue.Enqueue(0);
            while (queue.Count != 0)
            {
                int i = queue.Dequeue();
                for (int j = 0; j < vertices; j++)
                {
                    if (matrix1[i, j] != 0)
                    {
                        if (check[j] != 0) {
                            continue;
                        }
                        check[j] = 1;
                        queue.Enqueue(j);
                    }
                }
            }

            foreach (int k in check)
            {
                if (k == 0)
                {
                    MessageBox.Show("The Graph is not Connected");
                    return;
                }
            }

            MessageBox.Show("The Graph is Connected");
            return;

            // здесь писать логику проверки

        }

        public bool isNumber(string text)
        {
            var chArr = text.ToCharArray();
            if (!chArr.Any(x => x >= '0' && x <= '9'))
            {
                return false;
            }

          
            return true;
        }
        
    }
        
}
