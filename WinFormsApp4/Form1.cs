using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked & ( radioButton1.Checked | radioButton2.Checked ))
            {
                try
                {
                    float wy = float.Parse(textBox1.Text);


                    label2.Text = (wy - 100).ToString();
                }
                catch (Exception)
                {
                    label2.Text = ("podaj wzrost w cm");

                    throw;
                }
                   
            }
            else
            {
                if (checkBox1.Checked & radioButton1.Checked )
                {
                    try
                    {
                        float wy = float.Parse(textBox1.Text);


                        label2.Text = ((wy - 100)*0.85).ToString();

                    }
                    catch (Exception)
                    {
                        label2.Text = ("podaj wzrost w cm");
                        throw;
                    }

                }
                else
                {
                    if ((checkBox1.Checked & radioButton2.Checked))
                    {
                        try
                        {
                            float wy = float.Parse(textBox1.Text);


                            label2.Text = ((wy - 100) * 0.9).ToString();

                        }
                        catch (Exception)
                        {
                            label2.Text = ("podaj wzrost w cm");

                            throw;
                        }

                    }
                }
            }
                
            
        }

        
    }
}
