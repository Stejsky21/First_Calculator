using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double result;
        public static bool isTextBoxActive = true;

        public Form1()
        {
            InitializeComponent();

            textBox1.LostFocus += new EventHandler(TextBox_LostFocus);
            textBox3.LostFocus += new EventHandler(TextBox_LostFocus);

            button2.Click += new EventHandler(button_Click);
            button3.Click += new EventHandler(button_Click);
            button4.Click += new EventHandler(button_Click);
            button5.Click += new EventHandler(button_Click);
            button6.Click += new EventHandler(button_Click);
            button7.Click += new EventHandler(button_Click);
            button8.Click += new EventHandler(button_Click);
            button9.Click += new EventHandler(button_Click);
            button10.Click += new EventHandler(button_Click);
            button11.Click += new EventHandler(button_Click);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (comboBox1.SelectedItem == "+")
            {
                result = double.Parse(textBox1.Text) + double.Parse(textBox3.Text);
                textBox4.Text = result.ToString();
            }

            if (comboBox1.SelectedItem == "-")
            {
                result = double.Parse(textBox1.Text) - double.Parse(textBox3.Text);
                textBox4.Text = result.ToString();
            }

            if (comboBox1.SelectedItem == "*")
            {
                result = double.Parse(textBox1.Text) * double.Parse(textBox3.Text);
                textBox4.Text = result.ToString();
            }

            if (comboBox1.SelectedItem == "/")
            {
                result = double.Parse(textBox1.Text) / double.Parse(textBox3.Text);
                textBox4.Text = result.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedItem = null;
            isTextBoxActive = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isTextBoxActive)
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {
                textBox3.Text = textBox3.Text + button.Text;
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if((sender as TextBox).Name == "textBox1")
            {
                isTextBoxActive = true;
            }
            else
            {
                isTextBoxActive = false;
            }
        }
    }
}
