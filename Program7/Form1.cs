using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label11.Visible = false;
            textBox11.Visible = false;
            label12.Visible = false;
            textBox12.Visible = false;
            label13.Visible = false;
            textBox13.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (byte o = 0; o <= 9; o++)
                for (byte g = 0; g <= 9; g++)
                    for (byte n = 0; n <= 9; n++)
                        for (byte b = 0; b <= 9; b++)
                            for (byte r = 0; r <= 9; r++)
                                for (byte a = 0; a <= 9; a++)
                                    for (byte v = 0; v <= 9; v++)
                                        for (byte y = 0; y <= 9; y++)
                                            for (byte l = 0; l <= 9; l++)
                                                for (byte k = 0; k <= 9; k++)
                                                {
                                                    bool flag_o = (o != g) && (o != n) && (o != b) && (o != r) && (o != a) && (o != v) && (o != y) && (o != l) && (o != k);
                                                    bool flag_g = (g != n) && (g != b) && (g != r) && (g != a) && (g != v) && (g != y) && (g != l) && (g != k);
                                                    bool flag_n = (n != b) && (n != r) && (n != a) && (n != v) && (n != y) && (n != l) && (n != k);
                                                    bool flag_b = (b != r) && (b != a) && (b != v) && (b != y) && (b != l) && (b != k);
                                                    bool flag_r = (r != a) && (r != v) && (r != y) && (r != l) && (r != k);
                                                    bool flag_a = (a != v) && (a != y) && (a != l) && (a != k);
                                                    bool flag_v = (v != y) && (v != l) && (v != k);
                                                    bool flag_y = (y != l) && (y != k);
                                                    bool flag_l = (l != k);
                                                    bool flag = flag_o && flag_g && flag_n && flag_b && flag_r && flag_a && flag_v && flag_y && flag_l;
                                                    long ogonb = o * 10000 + g * 1000 + o * 100 + n * 10 + b;
                                                    long gora = g * 1000 + o * 100 + r * 10 + a;
                                                    long vylkan = v * 100000 + y * 10000 + l * 1000 + k * 100 + a * 10 + n;
                                                    if ((ogonb + gora == vylkan) && (flag == true))
                                                    {
                                                        label11.Visible = true;
                                                        textBox11.Visible = true;
                                                        label12.Visible = true;
                                                        textBox12.Visible = true;
                                                        label13.Visible = true;
                                                        textBox13.Visible = true;

                                                        textBox1.Text = Convert.ToString(o);
                                                        textBox2.Text = Convert.ToString(g);
                                                        textBox3.Text = Convert.ToString(n);
                                                        textBox4.Text = Convert.ToString(b);
                                                        textBox5.Text = Convert.ToString(r);
                                                        textBox6.Text = Convert.ToString(a);
                                                        textBox7.Text = Convert.ToString(v);
                                                        textBox8.Text = Convert.ToString(y);
                                                        textBox9.Text = Convert.ToString(l);
                                                        textBox10.Text = Convert.ToString(k);

                                                        textBox11.Text = Convert.ToString(ogonb);
                                                        textBox12.Text = Convert.ToString(gora);
                                                        textBox13.Text = Convert.ToString(vylkan);
                                                    }

                                                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
