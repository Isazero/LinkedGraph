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
            string vertices = comboBox2.Text;
            ShowAdjencyMatrix(vertices);
        }

        private void ShowAdjencyMatrix(string vertices)
        {
            switch (vertices)
            {
                case "2":
                    textBox1.Show();
                    textBox2.Show();
                    textBox10.Show();
                    textBox9.Show();
                break;
                case "3":
                    textBox1.Show();
                    textBox2.Show();
                    textBox3.Show();
                    textBox10.Show();
                    textBox9.Show();
                    textBox8.Show();
                    textBox15.Show();
                    textBox14.Show();
                    textBox13.Show();
                    break;
                case "4":
                    textBox1.Show();
                    textBox2.Show();
                    textBox3.Show();
                    textBox4.Show();
                    textBox10.Show();
                    textBox9.Show();
                    textBox8.Show();
                    textBox7.Show();
                    textBox15.Show();
                    textBox14.Show();
                    textBox13.Show();
                    textBox12.Show();
                    textBox20.Show();
                    textBox19.Show();
                    textBox18.Show();
                    textBox17.Show();
                    break;
            }
        }
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
