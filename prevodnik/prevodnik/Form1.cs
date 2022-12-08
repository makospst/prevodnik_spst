using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prevodnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //IPv4
        private void button1_Click(object sender, EventArgs e)
        {
            //binární > decimální
            if (checkBox1.Checked)
            {
                int cislo = int.Parse(textBox1.Text);
                int zaklad = Convert.ToInt32(cislo.ToString(), 2);
                int cislo2 = int.Parse(textBox2.Text);
                int zaklad2 = Convert.ToInt32(cislo2.ToString(), 2);
                int cislo3 = int.Parse(textBox3.Text);
                int zaklad3 = Convert.ToInt32(cislo3.ToString(), 2);
                int cislo4 = int.Parse(textBox4.Text);
                int zaklad4 = Convert.ToInt32(cislo4.ToString(), 2);
                textBox5.Text = Convert.ToString(zaklad);
                textBox6.Text = Convert.ToString(zaklad2);
                textBox7.Text = Convert.ToString(zaklad3);
                textBox8.Text = Convert.ToString(zaklad4);
            }
            //binární > hexadecimální
            else if (checkBox2.Checked)
            {
                int cislo = int.Parse(textBox1.Text);
                int zaklad = Convert.ToInt32(cislo.ToString(), 2);
                string zakladd = Convert.ToString(zaklad, 16);
                int cislo2 = int.Parse(textBox2.Text);
                int zaklad2 = Convert.ToInt32(cislo2.ToString(), 2);
                string zakladd2 = Convert.ToString(zaklad2, 16);
                int cislo3 = int.Parse(textBox3.Text);
                int zaklad3 = Convert.ToInt32(cislo3.ToString(), 2);
                string zakladd3 = Convert.ToString(zaklad3, 16);
                int cislo4 = int.Parse(textBox4.Text);
                int zaklad4 = Convert.ToInt32(cislo4.ToString(), 2);
                string zakladd4 = Convert.ToString(zaklad4, 16);
                textBox5.Text = zakladd;
                textBox6.Text = zakladd2;
                textBox7.Text = zakladd3;
                textBox8.Text = zakladd4;
            }
            //decimální > binární
            else if (checkBox3.Checked)
            {
                int cislo = int.Parse(textBox1.Text);
                string zaklad = Convert.ToString(cislo, 2);
                int cislo2 = int.Parse(textBox2.Text);
                string zaklad2 = Convert.ToString(cislo2, 2);
                int cislo3 = int.Parse(textBox3.Text);
                string zaklad3 = Convert.ToString(cislo3, 2);
                int cislo4 = int.Parse(textBox4.Text);
                string zaklad4 = Convert.ToString(cislo4, 2);
                textBox5.Text = zaklad;
                textBox6.Text = zaklad2;
                textBox7.Text = zaklad3;
                textBox8.Text = zaklad4;
            }
            //decimální > hexadecimální
            else if (checkBox4.Checked)
            {
                int cislo = int.Parse(textBox1.Text);
                string zaklad = Convert.ToString(cislo, 16);
                int cislo2 = int.Parse(textBox2.Text);
                string zaklad2 = Convert.ToString(cislo2, 16);
                int cislo3 = int.Parse(textBox3.Text);
                string zaklad3 = Convert.ToString(cislo3, 16);
                int cislo4 = int.Parse(textBox4.Text);
                string zaklad4 = Convert.ToString(cislo4, 16);
                textBox5.Text = zaklad;
                textBox6.Text = zaklad2;
                textBox7.Text = zaklad3;
                textBox8.Text = zaklad4;
            }
            //hexadecimální > binární
            else if (checkBox5.Checked)
            {
                string hax = Convert.ToString(textBox1.Text);
                int decv = int.Parse(hax, System.Globalization.NumberStyles.HexNumber);
                int v = int.Parse(Convert.ToString(decv));
                string vysledek = Convert.ToString(v, 2);
                string hax2 = Convert.ToString(textBox2.Text);
                int decv2 = int.Parse(hax2, System.Globalization.NumberStyles.HexNumber);
                int v2 = int.Parse(Convert.ToString(decv2));
                string vysledek2 = Convert.ToString(v2, 2);
                string hax3 = Convert.ToString(textBox3.Text);
                int decv3 = int.Parse(hax3, System.Globalization.NumberStyles.HexNumber);
                int v3 = int.Parse(Convert.ToString(decv3));
                string vysledek3 = Convert.ToString(v3, 2);
                string hax4 = Convert.ToString(textBox4.Text);
                int decv4 = int.Parse(hax4, System.Globalization.NumberStyles.HexNumber);
                int v4 = int.Parse(Convert.ToString(decv4));
                string vysledek4 = Convert.ToString(v4, 2);
                textBox5.Text = vysledek;
                textBox6.Text = vysledek2;
                textBox7.Text = vysledek3;
                textBox8.Text = vysledek4;
            }
            //hexadecimální > decimální
            else if (checkBox6.Checked)
            {
                string hax = Convert.ToString(textBox1.Text);
                int decv = int.Parse(hax, System.Globalization.NumberStyles.HexNumber);
                string hax2 = Convert.ToString(textBox2.Text);
                int decv2 = int.Parse(hax2, System.Globalization.NumberStyles.HexNumber);
                string hax3 = Convert.ToString(textBox3.Text);
                int decv3 = int.Parse(hax3, System.Globalization.NumberStyles.HexNumber);
                string hax4 = Convert.ToString(textBox4.Text);
                int decv4 = int.Parse(hax4, System.Globalization.NumberStyles.HexNumber);
                textBox5.Text = Convert.ToString(decv);
                textBox6.Text = Convert.ToString(decv2);
                textBox7.Text = Convert.ToString(decv3);
                textBox8.Text = Convert.ToString(decv4);
            }
        }

        //Zavření programu
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //vymazání textboxů
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        //Zavření programu
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Vymazání textboxů
        private void button6_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
        }

        //IPv6
        private void button4_Click(object sender, EventArgs e)
        {
            //binární > decimální
            if (checkBox7.Checked)
            {
                int cislo = int.Parse(textBox9.Text);
                int zaklad = Convert.ToInt32(cislo.ToString(), 2);
                int cislo2 = int.Parse(textBox10.Text);
                int zaklad2 = Convert.ToInt32(cislo2.ToString(), 2);
                int cislo3 = int.Parse(textBox11.Text);
                int zaklad3 = Convert.ToInt32(cislo3.ToString(), 2);
                int cislo4 = int.Parse(textBox12.Text);
                int zaklad4 = Convert.ToInt32(cislo4.ToString(), 2);
                int cislo5 = int.Parse(textBox13.Text);
                int zaklad5 = Convert.ToInt32(cislo5.ToString(), 2);
                int cislo6 = int.Parse(textBox14.Text);
                int zaklad6 = Convert.ToInt32(cislo6.ToString(), 2);
                int cislo7 = int.Parse(textBox15.Text);
                int zaklad7 = Convert.ToInt32(cislo7.ToString(), 2);
                int cislo8 = int.Parse(textBox16.Text);
                int zaklad8 = Convert.ToInt32(cislo8.ToString(), 2);
                textBox17.Text = Convert.ToString(zaklad);
                textBox18.Text = Convert.ToString(zaklad2);
                textBox19.Text = Convert.ToString(zaklad3);
                textBox20.Text = Convert.ToString(zaklad4);
                textBox21.Text = Convert.ToString(zaklad5);
                textBox22.Text = Convert.ToString(zaklad6);
                textBox23.Text = Convert.ToString(zaklad7);
                textBox24.Text = Convert.ToString(zaklad8);
            }
            //binární > hexadecimální
            else if (checkBox8.Checked)
            {
                int cislo = int.Parse(textBox9.Text);
                int zaklad = Convert.ToInt32(cislo.ToString(), 2);
                string zakladd = Convert.ToString(zaklad, 16);
                int cislo2 = int.Parse(textBox10.Text);
                int zaklad2 = Convert.ToInt32(cislo2.ToString(), 2);
                string zakladd2 = Convert.ToString(zaklad2, 16);
                int cislo3 = int.Parse(textBox11.Text);
                int zaklad3 = Convert.ToInt32(cislo3.ToString(), 2);
                string zakladd3 = Convert.ToString(zaklad3, 16);
                int cislo4 = int.Parse(textBox12.Text);
                int zaklad4 = Convert.ToInt32(cislo4.ToString(), 2);
                string zakladd4 = Convert.ToString(zaklad4, 16);
                int cislo5 = int.Parse(textBox13.Text);
                int zaklad5 = Convert.ToInt32(cislo5.ToString(), 2);
                string zakladd5 = Convert.ToString(zaklad5, 16);
                int cislo6 = int.Parse(textBox14.Text);
                int zaklad6 = Convert.ToInt32(cislo6.ToString(), 2);
                string zakladd6 = Convert.ToString(zaklad6, 16);
                int cislo7 = int.Parse(textBox15.Text);
                int zaklad7 = Convert.ToInt32(cislo7.ToString(), 2);
                string zakladd7 = Convert.ToString(zaklad7, 16);
                int cislo8 = int.Parse(textBox16.Text);
                int zaklad8 = Convert.ToInt32(cislo8.ToString(), 2);
                string zakladd8 = Convert.ToString(zaklad8, 16);
                textBox17.Text = zakladd;
                textBox18.Text = zakladd2;
                textBox19.Text = zakladd3;
                textBox20.Text = zakladd4;
                textBox21.Text = zakladd5;
                textBox22.Text = zakladd6;
                textBox23.Text = zakladd7;
                textBox24.Text = zakladd8;
            }
            //decimální > binární
            else if (checkBox9.Checked)
            {
                int cislo = int.Parse(textBox9.Text);
                string zaklad = Convert.ToString(cislo, 2);
                int cislo2 = int.Parse(textBox10.Text);
                string zaklad2 = Convert.ToString(cislo2, 2);
                int cislo3 = int.Parse(textBox11.Text);
                string zaklad3 = Convert.ToString(cislo3, 2);
                int cislo4 = int.Parse(textBox12.Text);
                string zaklad4 = Convert.ToString(cislo4, 2);
                int cislo5 = int.Parse(textBox13.Text);
                string zaklad5 = Convert.ToString(cislo5, 2);
                int cislo6 = int.Parse(textBox14.Text);
                string zaklad6 = Convert.ToString(cislo6, 2);
                int cislo7 = int.Parse(textBox15.Text);
                string zaklad7 = Convert.ToString(cislo7, 2);
                int cislo8 = int.Parse(textBox16.Text);
                string zaklad8 = Convert.ToString(cislo8, 2);
                textBox17.Text = zaklad;
                textBox18.Text = zaklad2;
                textBox19.Text = zaklad3;
                textBox20.Text = zaklad4;
                textBox21.Text = zaklad5;
                textBox22.Text = zaklad6;
                textBox23.Text = zaklad7;
                textBox24.Text = zaklad8;
            }
            //decimální > hexadecimální
            else if (checkBox10.Checked)
            {
                int cislo = int.Parse(textBox9.Text);
                string zaklad = Convert.ToString(cislo, 16);
                int cislo2 = int.Parse(textBox10.Text);
                string zaklad2 = Convert.ToString(cislo2, 16);
                int cislo3 = int.Parse(textBox11.Text);
                string zaklad3 = Convert.ToString(cislo3, 16);
                int cislo4 = int.Parse(textBox12.Text);
                string zaklad4 = Convert.ToString(cislo4, 16);
                int cislo5 = int.Parse(textBox13.Text);
                string zaklad5 = Convert.ToString(cislo5, 16);
                int cislo6 = int.Parse(textBox14.Text);
                string zaklad6 = Convert.ToString(cislo6, 16);
                int cislo7 = int.Parse(textBox15.Text);
                string zaklad7 = Convert.ToString(cislo7, 16);
                int cislo8 = int.Parse(textBox16.Text);
                string zaklad8 = Convert.ToString(cislo8, 16);
                textBox17.Text = zaklad;
                textBox18.Text = zaklad2;
                textBox19.Text = zaklad3;
                textBox20.Text = zaklad4;
                textBox21.Text = zaklad5;
                textBox22.Text = zaklad6;
                textBox23.Text = zaklad7;
                textBox24.Text = zaklad8;
            }
            //hexadecimální > binární
            else if (checkBox11.Checked)
            {
                string hax = Convert.ToString(textBox9.Text);
                int decv = int.Parse(hax, System.Globalization.NumberStyles.HexNumber);
                int v = int.Parse(Convert.ToString(decv));
                string vysledek = Convert.ToString(v, 2);
                string hax2 = Convert.ToString(textBox10.Text);
                int decv2 = int.Parse(hax2, System.Globalization.NumberStyles.HexNumber);
                int v2 = int.Parse(Convert.ToString(decv2));
                string vysledek2 = Convert.ToString(v2, 2);
                string hax3 = Convert.ToString(textBox11.Text);
                int decv3 = int.Parse(hax3, System.Globalization.NumberStyles.HexNumber);
                int v3 = int.Parse(Convert.ToString(decv3));
                string vysledek3 = Convert.ToString(v3, 2);
                string hax4 = Convert.ToString(textBox12.Text);
                int decv4 = int.Parse(hax4, System.Globalization.NumberStyles.HexNumber);
                int v4 = int.Parse(Convert.ToString(decv4));
                string vysledek4 = Convert.ToString(v4, 2);
                string hax5 = Convert.ToString(textBox13.Text);
                int decv5 = int.Parse(hax5, System.Globalization.NumberStyles.HexNumber);
                int v5 = int.Parse(Convert.ToString(decv5));
                string vysledek5 = Convert.ToString(v5, 2);
                string hax6 = Convert.ToString(textBox14.Text);
                int decv6 = int.Parse(hax6, System.Globalization.NumberStyles.HexNumber);
                int v6 = int.Parse(Convert.ToString(decv6));
                string vysledek6 = Convert.ToString(v6, 2);
                string hax7 = Convert.ToString(textBox15.Text);
                int decv7 = int.Parse(hax7, System.Globalization.NumberStyles.HexNumber);
                int v7 = int.Parse(Convert.ToString(decv7));
                string vysledek7 = Convert.ToString(v7, 2);
                string hax8 = Convert.ToString(textBox16.Text);
                int decv8 = int.Parse(hax8, System.Globalization.NumberStyles.HexNumber);
                int v8 = int.Parse(Convert.ToString(decv8));
                string vysledek8 = Convert.ToString(v8, 2);
                textBox17.Text = vysledek;
                textBox18.Text = vysledek2;
                textBox19.Text = vysledek3;
                textBox20.Text = vysledek4;
                textBox21.Text = vysledek5;
                textBox22.Text = vysledek6;
                textBox23.Text = vysledek7;
                textBox24.Text = vysledek8;
            }
            //hexadecimální > decimální
            else if (checkBox12.Checked)
            {
                string hax = Convert.ToString(textBox9.Text);
                int decv = int.Parse(hax, System.Globalization.NumberStyles.HexNumber);
                string hax2 = Convert.ToString(textBox10.Text);
                int decv2 = int.Parse(hax2, System.Globalization.NumberStyles.HexNumber);
                string hax3 = Convert.ToString(textBox11.Text);
                int decv3 = int.Parse(hax3, System.Globalization.NumberStyles.HexNumber);
                string hax4 = Convert.ToString(textBox12.Text);
                int decv4 = int.Parse(hax4, System.Globalization.NumberStyles.HexNumber);
                string hax5 = Convert.ToString(textBox13.Text);
                int decv5 = int.Parse(hax5, System.Globalization.NumberStyles.HexNumber);
                string hax6 = Convert.ToString(textBox14.Text);
                int decv6 = int.Parse(hax6, System.Globalization.NumberStyles.HexNumber);
                string hax7 = Convert.ToString(textBox15.Text);
                int decv7 = int.Parse(hax7, System.Globalization.NumberStyles.HexNumber);
                string hax8 = Convert.ToString(textBox16.Text);
                int decv8 = int.Parse(hax8, System.Globalization.NumberStyles.HexNumber);
                textBox17.Text = Convert.ToString(decv);
                textBox18.Text = Convert.ToString(decv2);
                textBox19.Text = Convert.ToString(decv3);
                textBox20.Text = Convert.ToString(decv4);
                textBox21.Text = Convert.ToString(decv5);
                textBox22.Text = Convert.ToString(decv6);
                textBox23.Text = Convert.ToString(decv7);
                textBox24.Text = Convert.ToString(decv8);
            }
        }
        //Tázání, zda si uživatel přeje program doopravdy zavřít
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete program zavřít?", "Jste si jisti?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

