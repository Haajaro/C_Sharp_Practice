using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // 1. Validate customer name
            string customerName = txtName.Text;

            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name.");
               
            }

            // 2. Validate numeric inputs using TryParse
            int age;
            int days;
            int experience;

            if (int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Enter a valid customer age.");
               
            }

            if (!int.TryParse(txtDays.Text, out days))
            {
                MessageBox.Show("Enter valid rental days.");
             
            }

            if (!int.TryParse(txtExperience.Text, out experience))
            {
                MessageBox.Show("Enter valid driving experience.");
               
            }

            // 3. Validate age
            if (age < 18 || age > 80)
            {
                MessageBox.Show("Age must be between 18 and 80.");
                return;
            }

            // 4. Validate rental days
            if (days < 1 || days > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.");
                return;
            }

            // 5. Validate driving experience
            if (experience < 0)
            {
                MessageBox.Show("Experience cannot be negative.");
                return;
            }

            // 6. Check customer eligibility
            if (age < 21)
            {
                MessageBox.Show("Not eligible. Customer must be at least 21.");
                lstResult.Text = "RENTAL REJECTED Customer must be at least 21 years old.";
                return;
            }

            if (experience < 1)
            {
                MessageBox.Show("Not eligible. At least 1 year of driving experience is required.");
               lstResult.Text = "RENTAL REJECTED At least 1 year of driving experience is required.";
                return;
            }

            // 7. Validate selections
            if (lstResult.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle type.");
                return;
            }

            if (lstResult.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an insurance option.");
                return;
            }

            string vehicle = grbbxvehicle.Text;
            string insurance =  grbbxinsurance.Text;

            // 8. Get daily rental rate
            decimal dailyRate = 0;

            switch (vehicle)
            {
                case "Economy":
                    dailyRate = 35m;
                    break;

                case "SUV":
                    dailyRate = 60m;
                    break;

                case "Luxury":
                    dailyRate = 100m;
                    break;
            }

            // 9. Check Luxury requirements
            if (vehicle == "Luxury" && (age < 25 || experience < 3))
            {
                MessageBox.Show(
                    "Luxury requires age 25 or above and 3 years of experience.");

                lstResult.Text =
                    "RENTAL REJECTED\nLuxury vehicles require age 25+ " +
                    "and at least 3 years of driving experience.";

                return;
            }

            // 10. Calculate basic rental cost
            decimal basicCost = dailyRate * days;

            // 11. Calculate discount
            decimal discountRate = 0;

            if (days >= 14)
            {
                discountRate = 0.10m;
            }
            else if (days >= 7)
            {
                discountRate = 0.05m;
            }

            decimal discount = basicCost * discountRate;
            decimal discountedCost = basicCost - discount;

            // 12. Calculate insurance
            decimal insuranceCost = 0;

            if (insurance == "Yes")
            {
                insuranceCost = 15m * days;
            }

            // 13. Calculate young-driver surcharge
            decimal surcharge = 0;

            if (age >= 21 && age <= 24)
            {
                surcharge = discountedCost * 0.10m;
            }

            // 14. Calculate final rental cost
            decimal finalCost =
                discountedCost + insuranceCost + surcharge;

            // 15. Display results



            lstResult.Items.Clear();

            lstResult.Items.Add("Customer Name: " + customerName);
            lstResult.Items.Add("Vehicle Type: " + vehicle);
            lstResult.Items.Add("Basic Rental Cost: $" + basicCost);
            lstResult.Items.Add("Discount: $" + discount);
            lstResult.Items.Add("Insurance Cost: $" + insuranceCost);
            lstResult.Items.Add("Young Driver Surcharge: $" + surcharge);
            lstResult.Items.Add("--------------------------");
            lstResult.Items.Add("Final Rental Cost: $" + finalCost);
            ;
        }

        // Clear all inputs and output
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtDays.Clear();
            txtExperience.Clear();
            lstResult.Items.Clear();

            txtName.Focus();
        }

        // Exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    }
