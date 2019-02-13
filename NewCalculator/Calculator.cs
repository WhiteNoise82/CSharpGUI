using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculator
{
    public enum Operators
    {
        Adder,
        Subtractor,
        Multiplier,
        Divider,
        Equal
    }
    public partial class Calculator : Form
    {

        public double Result = 0;
        public bool isNewNum = true;
        public bool isPoint = false;
        public Operators Opt = Operators.Adder;

        public Calculator()
        {
            InitializeComponent();
        }

        //Method
        public void SetNum(string num)
        {
            if (isNewNum && (num != "."))
            {
                NumScreen.Text = num;
                isNewNum = false;
                if (NumScreen.Text == "0")
                {
                    NumScreen.Text = num;
                }
                else
                {
                    NumScreen.Text = NumScreen.Text + num;
                }
            }

        }

        public void OptType(object sender)
        {
            Button optButton = (Button)sender;
            if (optButton.Text == "+") Opt = Operators.Adder;
            else if (optButton.Text == "-") Opt = Operators.Subtractor;
            else if (optButton.Text == "*") Opt = Operators.Multiplier;
            else if (optButton.Text == "/") Opt = Operators.Divider;
            else if (optButton.Text == "=") Opt = Operators.Equal;

        }

        public void Operation(Operators Opt)
        {
            double CalNum = double.Parse(NumScreen.Text);
            
            switch ((int)Opt)
            {
                case 0:
                    Result = Result + CalNum;
                    break;
                case 1:
                    Result = Result - CalNum;
                    break;
                case 2:
                    Result = Result * CalNum;
                    break;
                case 3:
                    Result = Result / CalNum;
                    break;
                case 4:                    
                    break;
                    
            }

            NumScreen.Text = Result.ToString();
            isNewNum = true;   
        }
        



        //UI
        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                Operation(Opt);
                OptType(sender);
            }
        }

        private void RstButton_Click(object sender, EventArgs e)
        {
            NumScreen.Text = "0";
            Result = 0;
            Opt = Operators.Adder;
            isNewNum = true;
        }
    }
}
