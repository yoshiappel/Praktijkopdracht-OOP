using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktijk_Opdracht_OOP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public static float ToSingle(double Width)
        {
            return (float)Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

            int rectWidth = int.Parse(textBox2.Text);
            int rectHeight = int.Parse(textBox1.Text);




            double OPP = rectWidth * rectHeight;

            label3.Text = OPP.ToString();

            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            Graphics Rect = CreateGraphics();

            Rect.DrawRectangle(pen, 10, 10, rectWidth, rectHeight);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
