using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        //payrate variable
        private const decimal payRate = 10.50m;
        public Form1()
        {
            InitializeComponent();
        }

        private void fstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //clearing boxes
            fstNameBox.Clear();
            lstNameBox.Clear();
            hrsWrkdBox.Clear();
            outputLabel.Text = String.Empty; //could have used " " instead 
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void sumzeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String firstName = fstNameBox.Text;
                String lastName = lstNameBox.Text;
                int hoursWorked = int.Parse(hrsWrkdBox.Text);

                decimal totalPay = hoursWorked * payRate;


                outputLabel.Text = firstName + " " + lastName + " worked " + hoursWorked + " at $" + payRate + " and earned $" + totalPay;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Please enter a valid number of hours worked.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
