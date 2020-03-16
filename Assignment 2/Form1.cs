using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
            
        
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
        

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Read values from textboxes.
            double Resistor1 = double.Parse(textBox1.Text);
            double Resistor2 = double.Parse(textBox2.Text);

            //Calculate total resistance.
            double TotalResistance = Resistor1 + Resistor2;

            //Value for Total Resistance in the lable
            label1.Text = "Total Resistance =" + TotalResistance;
        }
    }
}
