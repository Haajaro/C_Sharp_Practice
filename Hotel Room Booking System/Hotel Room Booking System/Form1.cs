using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Room_Booking_System
{
    public partial class HotelBooking : Form
    {
        public HotelBooking()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Validate Guest Name
            string guestName = txtName.Text.Trim();

            if (guestName == "")
            {
                MessageBox.Show("Please enter guest name.");
               txtName.Focus();
                return;
            }

            // 2. Validate numeric inputs using TryParse
            int age, nights, guests;

            if (!int.TryParse(txtAge.Text, out age) ||
                !int.TryParse(txtNights.Text, out nights) ||
                !int.TryParse(txtGuest.Text, out guests))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            // 3. Validate ranges
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                return;
            }

            // 4. Determine room rate using switch
            string roomType = txtNights.Text;
            double rate = 0;
            int capacity = 0;

            switch (roomType)
            {
                case "Standard":
                    rate = 130;
                    capacity = 2;
                    break;

                case "Normal":
                    rate = 50;
                    capacity = 6;
                    break;

                case "Hight":
                    rate = 80;
                    capacity = 4;
                    break;

                default:
                    MessageBox.Show("Please select a room type.");
                    return;
            }

            // 5. Use bool flag to approve or reject
            bool approved = true;

            if (guests > capacity)
            {
                approved = false;
            }

            if (!approved)
            {
                MessageBox.Show(
                    "Booking Rejected! Too many guests for this room.");
                return;
            }

            // 6. Calculate basic cost
            double basicCost = rate * nights;

            // 7. Calculate length-of-stay discount
            double discountRate = 0;

            if (nights >= 10)
            {
                discountRate = 0.12;
            }
            else if (nights >= 5)
            {
                discountRate = 0.05;
            }

            double discount = basicCost * discountRate;
            double subtotal = basicCost - discount;

            // 8. Add breakfast cost
            double breakfastCost = 0;

            if (checkBoxBreakFast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            subtotal += breakfastCost;

            // 9. Add service surcharge for more than 4 guests
            double serviceSurcharge = 0;

            if (guests > 4)
            {
                serviceSurcharge = subtotal * 0.05;
            }

            subtotal += serviceSurcharge;

            // 10. Additional senior discount
            double seniorDiscount = 0;

            if (age >= 60)
            {
                seniorDiscount = subtotal * 0.05;
            }

            double finalCost = subtotal - seniorDiscount;

            // 11. Display results in ListBox
            lstResult.Items.Clear();

            lstResult.Items.Add("Booking Approved");
            lstResult.Items.Add("Guest Name: " + guestName);
            lstResult.Items.Add("Guest Age: " + age);
            lstResult.Items.Add("Room Type: " + roomType);
            lstResult.Items.Add("Guests: " + guests);
            lstResult.Items.Add("Nights: " + nights);
            lstResult.Items.Add("Rate Per Night: $" + rate.ToString("F2"));
            lstResult.Items.Add("Basic Cost: $" + basicCost.ToString("F2"));
            lstResult.Items.Add("Stay Discount: $" + discount.ToString("F2"));
            lstResult.Items.Add("Breakfast: $" + breakfastCost.ToString("F2"));
            lstResult.Items.Add("Service Surcharge: $" + serviceSurcharge.ToString("F2"));
            lstResult.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));
            lstResult.Items.Add("--------------------------------");
            lstResult.Items.Add("Final Cost: $" + finalCost.ToString("F2"));

            // Clear all inputs and results
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtGuest.Clear();

            radioBtnStandard.Checked = false;
            radioBtnNormal.Checked = false;
            radioBtnHight.Checked = false;

            checkBoxBreakFast.Checked = false;
           lstResult.Items.Clear();


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }
    }
    }
}
            
        //private void btnClear_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    // Close the application
        //    this.Close();
        //}
    




