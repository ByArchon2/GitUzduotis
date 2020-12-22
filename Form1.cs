using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitUzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool tikrinimas(string txt)
        {
            return double.TryParse(txt, out _);
        }

        int[] array=new int[10];
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            textBox1.Clear();
            if (i != 10)
            {

                if (tikrinimas(txt))
                {
                    int a = Convert.ToInt32(txt);
                    array[i] = a;
                    i++;
                    richTextBox1.Clear();
                    richTextBox1.Text = "Jūsų įvesti skaičiai:";
                    for(int j=0;j<i;j++)
                    {
                        richTextBox1.AppendText(" "+ array[j].ToString());
                    }
                    label3.Text = "Jums dar trūksta " + (10 - i) + " skaičių";
                }
                else
                {
                    MessageBox.Show("Blogai ivesti duomenys");
                }
            }
            if (i == 10)
            {
                int suma = 0;
                for (int j = 0; j < i; j++)
                {
                    suma += array[j];
                }
                richTextBox1.AppendText(Environment.NewLine + "Šiu skaičių suma = " +suma.ToString());
                label3.Text = "Masyvas užpildytas";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string txt = textBox2.Text;
            textBox2.Clear();
            richTextBox2.Clear();
            if (tikrinimas(txt))
            {
                int a = Convert.ToInt32(txt);
                for (int k = 0; k < a; k++)
                {
                    for (int l = 0; l < a - 1 - k; l++)
                        richTextBox2.AppendText(" ");
                    for (int l = 0; l < k+1; l++)
                        richTextBox2.AppendText("* ");
                    richTextBox2.AppendText(Environment.NewLine);
                }
            }

        }
    }
}
