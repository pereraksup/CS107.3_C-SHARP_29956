using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07_2024._03._13
{//lab sheet4
    public partial class Form1 : Form
    {
        string operation = "";
        double result_value = 0;
        bool is_operatio_Perfomed=false;




        public Form1()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void operatio_Perfomed(object sender, EventArgs e)
        {
            
            {
                if (result_value != 0)
                {
                    button2.PerformClick();
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(textBox1.Text);
                    label1.Text = result_value + operation;
                    is_operatio_Perfomed = true;
                }

                else
                {
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(textBox1.Text);
                    label1.Text = result_value + operation;
                    is_operatio_Perfomed = true;

                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" || is_operatio_Perfomed)
            {
                textBox1.Clear();//clear initial value

            }
            Button btn = (Button)sender;
            if(btn.Text=="0") 
            {
             if(textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else
            {
                textBox1.Text= textBox1.Text + btn.Text;
            }
             is_operatio_Perfomed=false;


        }

        private void button15_Click(object sender, EventArgs e)
        {

        
                switch(operation)
                {
                    case "+":
                        textBox1.Text=(result_value + double.Parse(textBox1.Text)).ToString();
                        break;

                    case "-":
                        textBox1.Text = (result_value - double.Parse(textBox1.Text)).ToString();
                        break;

                    case "*":
                        textBox1.Text = (result_value / double.Parse(textBox1.Text)).ToString();
                        break;

                    case "/":
                        textBox1.Text = (result_value * double.Parse(textBox1.Text)).ToString();
                        break;
                }
        }
    }
}

