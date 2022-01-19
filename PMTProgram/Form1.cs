using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTProgram
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
             InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principle = double.Parse(txtPrincipal.Text);
            double numberofpayments = double.Parse(txtNop.Text);
            double interest = double.Parse(txtInterest.Text);
            double pmt = -interest * (principle * Math.Pow(1 + interest, numberofpayments)) / ((Math.Pow(1 + interest, numberofpayments) - 1));
            txtPayments.Text = (-pmt).ToString();


        }
    }
}
