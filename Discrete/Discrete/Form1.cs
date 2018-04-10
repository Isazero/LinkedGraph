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
        public int[,] matrix1;
        public int[,] matrix2;

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
            matrix1 = new int[vertices, vertices];
            ShowAdjencyMatrix1(vertices);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int vertices = Convert.ToInt32(comboBox1.Text);
            matrix2 = new int[vertices, vertices];
            ShowAdjencyMatrix2(vertices);
        }

        private void ShowAdjencyMatrix2(int vertices)
        {
            label4.Show();

            #region textBoxes

            var textBoxes = new[]
            {
                textBox26,
                textBox27,
                textBox28,
                textBox29,
                textBox30,
                textBox31,
                textBox32,
                textBox33,
                textBox34,
                textBox35,
                textBox36,
                textBox37,
                textBox38,
                textBox39,
                textBox40,
                textBox41,
                textBox42,
                textBox43,
                textBox44,
                textBox45,
                textBox46,
                textBox47,
                textBox48,
                textBox49,
                textBox50
            };

            #endregion

            switch (vertices)
            {
                case 2:
                    foreach (var box in textBoxes)
                    {
                        if (box == textBox50 || box == textBox49
                                             || box == textBox45 || box == textBox44)
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
                        if (box == textBox50 || box == textBox49 || box == textBox48
                            || box == textBox45 || box == textBox44 || box == textBox43
                            || box == textBox40 || box == textBox39 || box == textBox38)
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
                        if (box == textBox50 || box == textBox49 || box == textBox48 || box == textBox47
                            || box == textBox45 || box == textBox44 || box == textBox43 || box == textBox42
                            || box == textBox40 || box == textBox39 || box == textBox38 || box == textBox37
                            || box == textBox35 || box == textBox34 || box == textBox33 || box == textBox32)
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
                textBox25,
                textBox26,
                textBox27,
                textBox28,
                textBox29,
                textBox30,
                textBox31,
                textBox32,
                textBox33,
                textBox34,
                textBox35,
                textBox36,
                textBox37,
                textBox38,
                textBox39,
                textBox40,
                textBox41,
                textBox42,
                textBox43,
                textBox44,
                textBox45,
                textBox46,
                textBox47,
                textBox48,
                textBox49,
                textBox50
            };

            #endregion

            foreach (var box in textBoxes)
            {
                box.Clear();
            }
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox50.Text))
            {
                matrix2[0, 0] = Convert.ToInt32(textBox50.Text);
            }
            else
            {
                textBox50.Text = "";
            }
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox49.Text))
            {
                matrix2[0, 1] = Convert.ToInt32(textBox49.Text);
            }
            else
            {
                textBox49.Text = "";
            }
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox48.Text))
            {
                matrix2[0, 2] = Convert.ToInt32(textBox48.Text);
            }
            else
            {
                textBox48.Text = "";
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox47.Text))
            {
                matrix2[0, 3] = Convert.ToInt32(textBox47.Text);
            }
            else
            {
                textBox47.Text = "";
            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox46.Text))
            {
                matrix2[0, 4] = Convert.ToInt32(textBox46.Text);
            }
            else
            {
                textBox46.Text = "";
            }
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox45.Text))
            {
                matrix2[1, 0] = Convert.ToInt32(textBox45.Text);
            }
            else
            {
                textBox45.Text = "";
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox44.Text))
            {
                matrix2[1, 1] = Convert.ToInt32(textBox44.Text);
            }
            else
            {
                textBox44.Text = "";
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox43.Text))
            {
                matrix2[1, 2] = Convert.ToInt32(textBox43.Text);
            }
            else
            {
                textBox43.Text = "";
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox42.Text))
            {
                matrix2[1, 3] = Convert.ToInt32(textBox42.Text);
            }
            else
            {
                textBox42.Text = "";
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox41.Text))
            {
                matrix2[1, 4] = Convert.ToInt32(textBox41.Text);
            }
            else
            {
                textBox41.Text = "";
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox40.Text))
            {
                matrix2[2, 0] = Convert.ToInt32(textBox40.Text);
            }
            else
            {
                textBox40.Text = "";
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox39.Text))
            {
                matrix2[2, 1] = Convert.ToInt32(textBox39.Text);
            }
            else
            {
                textBox39.Text = "";
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox38.Text))
            {
                matrix2[2, 2] = Convert.ToInt32(textBox38.Text);
            }
            else
            {
                textBox38.Text = "";
            }
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox37.Text))
            {
                matrix2[2, 3] = Convert.ToInt32(textBox37.Text);
            }
            else
            {
                textBox37.Text = "";
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox36.Text))
            {
                matrix2[2, 4] = Convert.ToInt32(textBox36.Text);
            }
            else
            {
                textBox36.Text = "";
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox35.Text))
            {
                matrix2[3, 0] = Convert.ToInt32(textBox35.Text);
            }
            else
            {
                textBox35.Text = "";
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox34.Text))
            {
                matrix2[3, 1] = Convert.ToInt32(textBox34.Text);
            }
            else
            {
                textBox34.Text = "";
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox33.Text))
            {
                matrix2[3, 2] = Convert.ToInt32(textBox33.Text);
            }
            else
            {
                textBox33.Text = "";
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox32.Text))
            {
                matrix2[3, 3] = Convert.ToInt32(textBox32.Text);
            }
            else
            {
                textBox32.Text = "";
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox31.Text))
            {
                matrix2[3, 4] = Convert.ToInt32(textBox31.Text);
            }
            else
            {
                textBox31.Text = "";
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox30.Text))
            {
                matrix2[4, 0] = Convert.ToInt32(textBox30.Text);
            }
            else
            {
                textBox30.Text = "";
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox29.Text))
            {
                matrix2[4, 1] = Convert.ToInt32(textBox29.Text);
            }
            else
            {
                textBox29.Text = "";
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox28.Text))
            {
                matrix2[4, 2] = Convert.ToInt32(textBox28.Text);
            }
            else
            {
                textBox28.Text = "";
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox27.Text))
            {
                matrix2[4, 3] = Convert.ToInt32(textBox27.Text);
            }
            else
            {
                textBox27.Text = "";
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBox26.Text))
            {
                matrix2[4, 4] = Convert.ToInt32(textBox26.Text);
            }
            else
            {
                textBox26.Text = "";
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
                textBox25,
                textBox26,
                textBox27,
                textBox28,
                textBox29,
                textBox30,
                textBox31,
                textBox32,
                textBox33,
                textBox34,
                textBox35,
                textBox36,
                textBox37,
                textBox38,
                textBox39,
                textBox40,
                textBox41,
                textBox42,
                textBox43,
                textBox44,
                textBox45,
                textBox46,
                textBox47,
                textBox48,
                textBox49,
                textBox50
            };

            #endregion

            foreach (var box in textBoxes)
            {
                if (box.Visible && box.Text.Equals(""))
                {
                    MessageBox.Show("One of the TextBoxes is empty");
                    return;
                }
            }
            // здесь писать логику проверки
            if (matrix1.Length != matrix2.Length)
            {
                MessageBox.Show("Vertices are not the equal");
                
                return;
            }
            

        }

        public bool isNumber(string text)
        {
            var chArr = text.ToCharArray();
            if (!chArr.Any(x => x > '0' && x < '9'))
            {
                return false;
            }

            return true;
        }
    }

}
