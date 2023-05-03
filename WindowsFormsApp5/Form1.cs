using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string oper = "";
        double result_value = 0;
        bool is_operation_performed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonclick(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || is_operation_performed)
            {
                textBox1.Clear();
            }
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
            is_operation_performed = false;
        }

        private void operation(object sender, EventArgs e)
        {
            if (result_value != 0)
            {
                button13.PerformClick();
                Button btn = (Button)sender;
                oper = btn.Text;
                result_value = double.Parse(textBox1.Text);
                label1.Text = result_value + oper;
                is_operation_performed = true;
            }
            else
            {
                Button btn = (Button)sender;
                oper = btn.Text;
                result_value = double.Parse(textBox1.Text);
                label1.Text = result_value + oper;
                is_operation_performed = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+":
                    textBox1.Text = (result_value + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result_value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result_value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result_value / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
