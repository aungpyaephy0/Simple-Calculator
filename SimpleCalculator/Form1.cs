using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(txtFirst.Text);
            double secNum = double.Parse(txtSec.Text);
            double total = firstNum + secNum;
            lblDisplay.Text = "First Number: " + txtFirst.Text + "\n" + "\n"
                              + "Second Number: " + txtSec.Text + "\n" + "\n"
                              + "Result: " + total;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(txtFirst.Text);
            double secNum = double.Parse(txtSec.Text);
            double total = firstNum - secNum;
            lblDisplay.Text = "First Number: " + txtFirst.Text + "\n" + "\n"
                              + "Second Number: " + txtSec.Text + "\n" + "\n"
                              + "Result: " + total;
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(txtFirst.Text);
            double secNum = double.Parse(txtSec.Text);
            double total = firstNum * secNum;
            lblDisplay.Text = "First Number: " + txtFirst.Text + "\n" + "\n"
                              + "Second Number: " + txtSec.Text + "\n" + "\n"
                              + "Result: " + total;
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(txtFirst.Text);
            double secNum = double.Parse(txtSec.Text);
            double total = firstNum / secNum;
            lblDisplay.Text = "First Number: " + txtFirst.Text + "\n"+"\n"
                              + "Second Number: " + txtSec.Text + "\n" + "\n"
                              + "Result: " + total;
            if (firstNum/secNum == double.PositiveInfinity )
            {
                lblDisplay.Text = "Error";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtSec.Text = "";
            lblDisplay.Text = "";
        }
       
        
    }
}
