using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form69
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Weclome " + txtbox1.Text  +  txtbox5.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            int firstNum, secondNum;


            firstNum = Convert.ToInt32(textBox1.Text);
            secondNum = Convert.ToInt32(textBox2.Text);

            int result = firstNum + secondNum;

            txtbox3.Text = Convert.ToString(result);

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

            label5.Text = "Antal Tecken: " + textBox3.Text.Length.ToString();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            int firstNum, secondNum;


            firstNum = Convert.ToInt32(textBox1.Text);
            secondNum = Convert.ToInt32(textBox2.Text);

            int result = firstNum - secondNum;

            txtbox3.Text = Convert.ToString(result);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            int firstNum, secondNum;


            firstNum = Convert.ToInt32(textBox1.Text);
            secondNum = Convert.ToInt32(textBox2.Text);

            int result = firstNum * secondNum;

            txtbox3.Text = Convert.ToString(result);
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            int firstNum, secondNum;


            firstNum = Convert.ToInt32(textBox1.Text);
            secondNum = Convert.ToInt32(textBox2.Text);

            int result = firstNum / secondNum;

            txtbox3.Text = Convert.ToString(result);
        }
    }
}
