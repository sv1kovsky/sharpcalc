using System;
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
    public partial class Form2 : Form
    {
        private byte a1, a2, a3, a4;
        private byte b1, b2, b3, b4;
        private bool checkerror;
        private int bytes;
        private string stringdvoichka,bit8;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        unsafe private byte converting(string ip,ref bool c)
        {
            if (byte.TryParse(ip, out byte a))
            {
                a = Convert.ToByte(ip);
            }
            else c = true;
            return a;
        }
        private byte convertingtodecimal(string bitt8)
        {
            byte b = 0;
            int j = 7;
            for (int i = 0; i < 8; i++)
            {
                if (bitt8[i] == '1')
                {
                    b += (byte)(System.Math.Pow(2, j));
                }
                j--;
            }
            return b;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            checkerror = false;
            a1 = converting(ip1.Text, ref checkerror);
            a2 = converting(ip2.Text, ref checkerror);
            a3 = converting(ip3.Text, ref checkerror);
            a4 = converting(ip4.Text, ref checkerror);
            
            if (!checkerror)
            {
                bytes = converting(maskbytes.Text, ref checkerror);
                if (!checkerror & (bytes !=0) & (bytes < 32))
                {
                    for (int i = 0; i < 32; i++)
                    {
                        if (i < bytes) stringdvoichka += '1';
                        else stringdvoichka += '0';
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        for (int z = 0; z<8; z++)
                        {
                            bit8 += stringdvoichka[8 * i + z];
                        }
                        if (i == 0) b1 = convertingtodecimal(bit8);
                        if (i == 1) b2 = convertingtodecimal(bit8);
                        if (i == 2) b3 = convertingtodecimal(bit8);
                        if (i == 3) b4 = convertingtodecimal(bit8);
                        bit8 = "";
                    }
                    resultip.Text = "";
                    resultip.Text +=(b1 & a1) + ".";
                    resultip.Text +=(b2 & a2) + ".";
                    resultip.Text +=(b3 & a3) + ".";
                    resultip.Text +=(b4 & a4);
                    stringdvoichka = "";
                }
                else resultip.Text = "Неправильно введена битность маски";
            }
            else resultip.Text = "Неправильно введен IP адрес";
        }
    }
}
