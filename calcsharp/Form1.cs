using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcsharp
{
    public partial class Form1 : Form
    {
        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            Power,
            Abs,
            Radical,
            Ln,
            Precent
        }

        private bool uslovie = true; // операция в текст боксе
        private bool uslovie1 = true; // нельзя писать пока не нажмут clear
        private int i = -1;
        private double a, b, result;
        Operation op;
        string chislo;
        StreamWriter sw = new StreamWriter(@"D:\CalcResult.txt", true, System.Text.Encoding.Default);
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 1;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 2;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 3;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 4;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 5;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 6;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 7;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 8;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 9;
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (uslovie1) textBox1.Text += 0;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void butravno_Click(object sender, EventArgs e)
        {
            if (!uslovie & uslovie1)
            {
                if (i != 0)
                {
                    if (i < textBox1.TextLength && textBox1.Text[textBox1.TextLength - 1] != '-')
                    {
                        for (int j = i; j < textBox1.TextLength; j++)
                        {
                            chislo += textBox1.Text[j];
                        }
                        b = Convert.ToInt32(chislo);
                    }
                    else textBox1.Text = "Error";
                }
                if (textBox1.Text != "Error")
                {
                    textBox1.Text += "=";
                    switch (op)
                    {
                        case Operation.Add:
                            result = a + b;
                            break;
                        case Operation.Subtract:
                            result = a - b;
                            break;
                        case Operation.Multiply:
                            result = a * b;
                            break;
                        case Operation.Divide:
                            result = a / b;
                            break;
                        case Operation.Power:
                            result = System.Math.Pow(a, b);
                            break;
                        case Operation.Abs:
                            result = System.Math.Abs(a);
                            break;
                        case Operation.Radical:
                            result = System.Math.Sqrt(a);
                            break;
                        case Operation.Ln:
                            result = System.Math.Log(a);
                            break;
                        case Operation.Precent:
                            result = a * b * 0.01;
                            break;
                        default:
                            break;
                    }
                    textBox1.Text += result;
                    sw.WriteLine(textBox1.Text);
                }
                chislo = "";
                uslovie1 = false;
            }
        }

        

        private void butplus_Click(object sender, EventArgs e)
        {
            if ((uslovie) & ((textBox1.TextLength > 0) && (textBox1.Text[0] != '-') | (textBox1.TextLength > 1)))
            {
                op = Operation.Add;
                uslovie = false;
                chislo += textBox1.Text;
                a = Convert.ToInt32(chislo);
                chislo = "";
                textBox1.Text += "+";
                i = textBox1.TextLength;
            }
        }

        

        private void butminus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) textBox1.Text += '-';
            if (((!uslovie) && (textBox1.Text[textBox1.TextLength - 1] != '-')) & uslovie1) textBox1.Text += '-';
            if ((uslovie) && (textBox1.Text[textBox1.TextLength - 1] != '-'))
            {
                op = Operation.Subtract;
                uslovie = false;
                chislo = textBox1.Text;
                a = Convert.ToDouble(chislo);
                chislo = "";
                textBox1.Text += '-';
                i = textBox1.TextLength;
            }
            if (op == Operation.Subtract && (textBox1.Text[textBox1.TextLength - 2] != '-')) textBox1.Text += '-';
        }
        private void butmultiply_Click(object sender, EventArgs e)
        {
            if ((uslovie) & ((textBox1.TextLength > 0) && (textBox1.Text[0] != '-') | (textBox1.TextLength > 1)))
            {
                op = Operation.Multiply;
                uslovie = false;
                chislo += textBox1.Text;
                a = Convert.ToInt32(chislo);
                chislo = "";
                textBox1.Text += "*";
                i = textBox1.TextLength;
            }
        }

        private void butpower_Click(object sender, EventArgs e)
        {
            if ((uslovie) & ((textBox1.TextLength > 0) && (textBox1.Text[0] != '-') | (textBox1.TextLength > 1)))
            {
                op = Operation.Power;
                uslovie = false;
                chislo += textBox1.Text;
                a = Convert.ToInt32(chislo);
                chislo = "";
                textBox1.Text += "^";
                i = textBox1.TextLength;
            }
        }

        private void butradical_Click(object sender, EventArgs e)
        {
           if ((uslovie) & ((textBox1.TextLength > 0) && (textBox1.Text[0] != '-') | (textBox1.TextLength > 1)))
            {
                op = Operation.Radical;
                uslovie = false;
                uslovie1 = false;
                chislo = textBox1.Text;
                a = Convert.ToDouble(chislo);
                chislo = "";
                i = 0;
            }
        }

        private void butln_Click(object sender, EventArgs e)
        {
            if ((uslovie) & ((textBox1.TextLength > 0) && (textBox1.Text[0] != '-') | (textBox1.TextLength > 1)))
            {
                op = Operation.Ln;
                uslovie = false;
                chislo += textBox1.Text;
                a = Convert.ToInt32(chislo);
                chislo = "";
                i = 0;
            }
        }

        private void butabs_Click(object sender, EventArgs e)
        {
            if ((uslovie) & ((textBox1.TextLength > 0) && (textBox1.Text[0] != '-') | (textBox1.TextLength > 1)))
            {
                op = Operation.Abs;
                uslovie = false;
                chislo += textBox1.Text;
                a = Convert.ToInt32(chislo);
                chislo = "";
                i = 0;
            }
        }


        private void butdivide_Click(object sender, EventArgs e)
        {
            if ((uslovie) & ((textBox1.TextLength > 0) && (textBox1.Text[0] != '-') | (textBox1.TextLength > 1)))
            {
                op = Operation.Divide;
                uslovie = false;
                chislo += textBox1.Text;
                a = Convert.ToInt32(chislo);
                chislo = "";
                textBox1.Text += "/";
                i = textBox1.TextLength;
            }
        }

        private void calculateMaskToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form2 openForm = new Form2();
            openForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sw.Close();
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            chislo = "";
            textBox1.Text = "";
            uslovie = true;
            uslovie1 = true;
        }
        private void butce_Click(object sender, EventArgs e)
        {
            if ((textBox1.TextLength > 0) && uslovie1)
            {
                if (uslovie & i!=0)
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                if (i == 0)
                {
                    uslovie = true;
                    i = -1;
                }
                if (!uslovie && (i < textBox1.TextLength))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                    i--;
                }
                if (!uslovie && (i == textBox1.TextLength))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                    uslovie = true;
                }
            }
        }
    }
}
