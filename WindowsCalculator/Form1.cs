using System.IO;
using CalculatorFuncties;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {

        string invoer;
        string resultaat;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }

        void Plus()
        {
            if (textBox1.Text.EndsWith("+"))
            {
                return;
            }
            else if (textBox1.Text.EndsWith("-"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text += "+";
            }
        }

        void Min()
        {
            if (textBox1.Text.EndsWith("-"))
            {
                return;
            }
            else if (textBox1.Text.EndsWith("+"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text += "-";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char toets = e.KeyChar;

            if (char.IsDigit(toets))
            {
                textBox1.Text += toets;
            }
            else if (toets == '+')
            {
                Plus();
            }
            else if (toets == '-')
            {
                Min();
            }
            else if (toets == '=')
            {
                resultaat = Bereken.BerekenResultaat(textBox1.Text);
                textBox1.Text = resultaat;
            }
            else if (toets == (char)Keys.Back)
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            else if ((toets == 'C') || (toets == 'c') || (toets == (char)Keys.Escape))
            {
                textBox1.Text = string.Empty;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Plus();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            Min();
        }

        private void buttonIs_Click(object sender, EventArgs e)
        {
            
            //var output = Class1.BerekenResultaat(textBox1.Text);
            
            resultaat = Bereken.BerekenResultaat(textBox1.Text);
            textBox1.Text = resultaat;
            meldingLabel.Text = "Resultaat: " + resultaat;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   
    }
}

