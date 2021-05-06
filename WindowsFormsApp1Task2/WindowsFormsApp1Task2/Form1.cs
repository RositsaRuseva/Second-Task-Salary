using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double grossSalary, netSalary, taxedSalary;
        private void calculateButton_Click(object sender, EventArgs e)
        {
            grossSalary = double.Parse(grossTextBox.Text);
            //if the grossSalary is a round number (example: 2000, 3000, 4000) 
            //the taxation of the sallary should be implemented differently

            //for this application the biggest gross salary could be 4000 (ofc this can be changed)

            if (grossSalary <= 1000)
            {
                netSalary = grossSalary;
            }
            else if (grossSalary > 1000)
            {
                
                if (grossSalary == 2000 || grossSalary == 3000 || grossSalary == 4000)
                {
                    taxedSalary = grossSalary * 0.90;
                    netSalary = taxedSalary;
                }
                else
                {
                    taxedSalary = (grossSalary - 1000) * 0.90;
                    netSalary = taxedSalary;
                }
                
            }
            //unfortunately, I have not been able to understand very well the logic of taxation by 15%

            netTextBox.Text = netSalary.ToString();
            
           
        }
    }
}
