using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string numberA = "";
        public string numberB = "";
        public string numberR = "";
        public double valueA = 0.0;
        public double valueB = 0.0;
        public double valueR = 0.0;
        public string operatorul = "";
       
        void c()
        {

            numberA = "";
            numberB = "";
            numberR = "";
            valueA = 0.0;
            valueB = 0.0;
            valueR = 0.0;
            operatorul = "";
            textBox1.Text = numberA;
            
        }

        void change(string a, string b)
        {
            numberB = numberA;
            numberA = "";
            valueB = Convert.ToDouble(numberB);
            valueA = 0.0;
          

        }
        void update(string s) {
            numberA += s;
            textBox1.Text = numberA; 
            valueA = Convert.ToDouble(numberA);
        }
        void updatesign(string s)
        {

            valueA = -1 * Convert.ToDouble(numberA);
            numberA = valueA.ToString();
            textBox1.Text = numberA; 
            valueA = Convert.ToDouble(numberA);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //7
            update("7");
            
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8
            update("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //9
            update("9");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //4
            update("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5
            update("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //6
            update("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            update("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2
            update("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3
            update("3");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //0
            update("0");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //000
            update("000");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //+-
            if (valueA <= 0)
            {
                updatesign("+");
            }
            else
            {
                updatesign("-");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //.
            update(".");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //C
            c();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //+
            operatorul = "add";
            textBox2.Text = "+";
            change(numberB, numberA);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //-
            operatorul = "dif";
            textBox2.Text = "";
            change(numberB, numberA);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ///
            operatorul = "div";
            textBox2.Text = "/";
            change(numberB, numberA);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //*
            operatorul = "mult";
            textBox2.Text = "*";
            change(numberB, numberA);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //=

            if (operatorul == "add")
                valueR = valueA + valueB;
            else if (operatorul == "dif")
                valueR = valueB - valueA;
            else if (operatorul == "mult")
                valueR = valueA * valueB;
            else if (operatorul == "div")
                valueR = valueB / valueA;
            else { }
            numberR = valueR.ToString();
            textBox1.Text = numberR;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
