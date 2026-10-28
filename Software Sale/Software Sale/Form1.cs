using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
try
{
    // Check empty fields
    if (string.IsNullOrWhiteSpace(txtPackage.Text) ||
        string.IsNullOrWhiteSpace(txtprice.Text))
    {
        throw new Exception("Please fill in all fields.");
    }

    // Variables
    int NumberOfPackages = int.Parse(txtPackage.Text);
    double PricePerPackage = double.Parse(txtprice.Text);

    // Validate negative numbers
    if (NumberOfPackages <= 0)
    {
        throw new Exception("Number of packages must be greater than zero.");
    }

    if (PricePerPackage < 0)
    {
        throw new Exception("Price cannot be negative.");
    }

    // Subtotal
    double SubTotal = NumberOfPackages * PricePerPackage;

    // Discount
    double discountRate = 0;
    double discountAmount = 0;

    if (NumberOfPackages >= 10 && NumberOfPackages <= 19)
    {
        discountAmount = SubTotal * 0.2;
        discountRate = 20;
    }
    else if (NumberOfPackages >= 20 && NumberOfPackages <= 49)
    {
        discountAmount = SubTotal * 0.3;
        discountRate = 30;
    }
    else if (NumberOfPackages >= 50 && NumberOfPackages <= 99)
    {
        discountAmount = SubTotal * 0.4;
        discountRate = 40;
    }
    else if (NumberOfPackages >= 100)
    {
        discountAmount = SubTotal * 0.5;
        discountRate = 50;



        
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPackage.Clear();
            txtprice.Clear();

            listBox1.Items.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
