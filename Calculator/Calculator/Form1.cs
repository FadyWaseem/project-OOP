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
        Double resalt = 0;
        string operationperformed = "";
        bool isoperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0" || (isoperationperformed))
                textBox_result.Clear();

            isoperationperformed = false;
            Button button = (Button)sender;
            if (button.Text== ".")
            {
                if (!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text;

            }
            else
            textBox_result.Text = textBox_result.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
                Button button = (Button)sender;

                if (resalt!=0)
                {
                equal.PerformClick();
                operationperformed = button.Text;
                labeloperation.Text = resalt + " " + operationperformed;
                isoperationperformed = true;
                }
            else
            {

            
                operationperformed = button.Text;
                resalt = Double.Parse(textBox_result.Text);
                labeloperation.Text = resalt + " " + operationperformed;
                isoperationperformed = true;
            }
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resalt = 0;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textBox_result.Text = (resalt + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resalt - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "÷":
                    textBox_result.Text = (resalt / Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "x":
                    textBox_result.Text = (resalt * Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
            resalt = Double.Parse(textBox_result.Text);
            labeloperation.Text = " ";
        }

        private void delete_click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            labeloperation.Text = " ";
            resalt = 0;
        }
    }

}
