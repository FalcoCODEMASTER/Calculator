using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Fields 
        public decimal NumberOne = 0;
        public decimal NumberTwo = 0;
        private bool FirstInputFinished = false;
        private bool SecondInputFinished = false;
        private int SelectedCase;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        //When button is pressed add 0 to textbox
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        //When button is pressed add 1 to textbox
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        //When button is pressed add 2 to textbox
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        //When button is pressed add 3 to textbox
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        //When button is pressed add 4 to textbox
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        //When button is pressed add 5 to textbox
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        //When button is pressed add 6 to textbox
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        //When button is pressed add 7 to textbox
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        //When button is pressed add 8 to textbox
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        //When button is pressed add 9 to textbox
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }


        //When plus button is clicked
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //Select case Multiplay
            SelectedCase = 1;

            //Confirm first input finished
            FirstInputFinished = true;

            //Add string from textbox to NumberOne field
            if (FirstInputFinished == true && SecondInputFinished == false)
            {
                NumberOne = Int32.Parse(textBox1.Text);
                textBox1.Text = String.Empty;
            }
        }


        //When Minus button is clicke
        private void buttonMin_Click(object sender, EventArgs e)
        {
            //Select case Multiplay
            SelectedCase = 2;

            //Confirm first input finished
            FirstInputFinished = true;

            //Add string from textbox to NumberOne field
            if (FirstInputFinished == true && SecondInputFinished == false)
            {
                NumberOne = Int32.Parse(textBox1.Text);
                textBox1.Text = String.Empty;
            }
        }

        //When divide button is clicked
        private void buttonDeel_Click(object sender, EventArgs e)
        {
            //Select case Multiplay
            SelectedCase = 3;

            //Confirm first input finished
            FirstInputFinished = true;

            //Add string from textbox to NumberOne field
            if (FirstInputFinished == true && SecondInputFinished == false)
            {
                NumberOne = Int32.Parse(textBox1.Text);
                textBox1.Text = String.Empty;
            }
        }

        //When multiply button is clicked
        private void buttonKeer_Click(object sender, EventArgs e)
        {
            //Select case Multiplay
            SelectedCase = 4;

            //Confirm first input finished
            FirstInputFinished = true;

            //Add string from textbox to NumberOne field
            if (FirstInputFinished == true)
            {
                NumberOne = Int32.Parse(textBox1.Text);
                textBox1.Text = String.Empty;
            }
        }

        //When Equals button is clicked
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            //Confirm second input finished
            SecondInputFinished = true;

            //Add string from textbox to NumberTwo field
            NumberTwo = int.Parse(textBox1.Text);

            //New instance for math
            var calcer = new Math();

            //If both Inputs are given select given case
            if (SecondInputFinished == true && FirstInputFinished == true)
            {
                switch (SelectedCase)
                {
                    //Call Plus
                    case 1:
                        calcer.Plus((int)NumberOne, (int)NumberTwo);
                        textBox1.Text = calcer.Result.ToString();  
                        break;
                    
                    //Call Minus
                    case 2:
                        calcer.Minus((int)NumberOne, (int)NumberTwo);
                        textBox1.Text = calcer.Result.ToString();
                        break;

                    //Call divide
                    case 3:
                        calcer.Divide((int)NumberOne, (int)NumberTwo);
                        textBox1.Text = calcer.Result.ToString();
                        break;

                    //Call multiply 
                    case 4:
                        calcer.Multiply((int)NumberOne, (int)NumberTwo);
                        textBox1.Text = calcer.Result.ToString();
                        break;
                }
            }
        }

        //When "C" Clean button is called
        private void cleanInput_Click(object sender, EventArgs e)
        {
            //Reset calculator
            textBox1.Text = String.Empty;
            NumberTwo = 0;
            NumberOne = 0;
            FirstInputFinished = false;
            SecondInputFinished = false;    
        }
    }
}
