using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double P, R, N,Result;

        

        

        public void SimpleInt_Click(object sender, EventArgs e)
        {

            //Simple interest=P×i×n
            //   where:
            //       P = Principle
            //i = interest rate  
            // n = term of the loan
            textRe.Text = Maths.simpleInterest(Convert.ToDouble(textP.Text),
                Convert.ToDouble(textR.Text),
                Convert.ToDouble(textN.Text)).ToString();

        }

        public void CmpInt_Click(object sender, EventArgs e)
        {
            //Compound interest =[P(1 + i)^n]-p
            //P = Principle
            //i = interest rate in percentage terms
            //n = number of compounding periods for a year

            //balance = principle * Math.Pow(1 + interestRate, i)

            textRe.Text = Maths.compoundInterest(Convert.ToDouble(textP.Text),
                Convert.ToDouble(textR.Text),
                Convert.ToDouble(textN.Text)).ToString();

        }

        

        public Form1()
        {
            InitializeComponent();
        }

        public void test()
        {

        }

    }
}
