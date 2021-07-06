using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operationPerformed = "";
        bool isOperationPerfomed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (isOperationPerfomed))
                textBox1.Text = "";
             isOperationPerfomed = false;
            
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            result = Double.Parse(textBox1.Text);
            operationPerformed = button.Text;
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(result) + "" + operationPerformed;
            //isOperationPerfomed = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void result_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            switch(operationPerformed)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "mod":
                    textBox1.Text = (result % Double.Parse(textBox1.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 353;
            textBox1.Width = 222;

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width= 353;
            textBox1.Width = 222;
        }

        private void superToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 435;
            textBox1.Width = 343;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");

            log = Math.Log10(log);
            textBox1.Text = System.Convert.ToString(log);
        }

        private void button20_Click(object sender, EventArgs e)
        {

            double sq = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sq" + "(" + (textBox1.Text) + ")");

            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double power = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString( "(" + (textBox1.Text) + ") "+ "to the power of 2 " );

            power = Math.Pow(power, 2);
            textBox1.Text = System.Convert.ToString(power);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0,1);


            }
            else
            {
                textBox1.Text = "-"+ textBox1.Text;

            }
        }
    }
}
