using Microsoft.VisualBasic.Devices;

namespace calc0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, ans;
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 7;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            textBox1.Text += 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00" || textBox1.Text == "-0,00")
            {
                textBox1.Clear();
            }

            if (textBox1.Text != "")
            {
                textBox1.Text += ",";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
           num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();
            count = 1;

            if (textBox1.Text.Contains("+"))
            {
                ans = num1 + float.Parse(textBox1.Text);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }
            else {
                textBox1.Text = textBox1.Text + "-";
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { 
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            switch (count)
                        {
                            case 1: ans = num1 + float.Parse(textBox1.Text); break;
                            case 2: ans = num1 - float.Parse(textBox1.Text); break;
                            case 3: ans = num1 * float.Parse(textBox1.Text); break;
                            case 4: ans = num1 / float.Parse(textBox1.Text); break;
                            case 5: ans = num1 % float.Parse(textBox1.Text); break;
            }
            textBox1.Text = ans.ToString("0.00");
                    }
    }
}