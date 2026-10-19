using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            // 1. Declare variables
            int age, tickets;
            double baggageWeight, ticketPrice;

            bool bookingApproved = true;
            string rejectionReason = "";

            // 2. Validate numeric inputs using TryParse
            if (!int.TryParse(txtPassengerAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid passenger age.");
                return;
            }

            if (!int.TryParse(txtTickets.Text, out tickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }

            if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                return;
            }

            if (!double.TryParse(txtTickets.Text, out ticketPrice)
                || ticketPrice <= 0)
            {
                MessageBox.Show("Please enter a valid ticket price.");
                return;
            }

            // 3. Validate age
            if (age < 1 || age > 100)
            {
                bookingApproved = false;
                rejectionReason = "Passenger age must be between 1 and 100.";
            }

            // 4. Validate number of tickets
            else if (tickets < 1 || tickets > 5)
            {
                bookingApproved = false;
                rejectionReason = "Tickets must be between 1 and 5.";
            }

            // 5. Validate baggage weight
            else if (baggageWeight < 0 || baggageWeight > 50 * tickets)
            {
                bookingApproved = false;
                rejectionReason =
                    "Baggage cannot exceed 50 kg per passenger.";
            }

            // 6. Children below 12 cannot book First Class
            else if (age < 12 && grbbxtravel.Text == "First Class")
            {
                bookingApproved = false;
                rejectionReason =
                    "Passengers below 12 cannot book First Class.";
            }

            // 7. Reject invalid bookings
            if (!bookingApproved)
            {
                MessageBox.Show("Booking Rejected!\n" + rejectionReason);

                lstResult.Items.Clear();
                lstResult.Items.Add("Booking Rejected");
                lstResult.Items.Add(rejectionReason);
                return;
            }

            // 8. Calculate basic ticket cost
            double basicCost = ticketPrice * tickets;

            // 9. Calculate ticket discount
            double discountRate = 0;

            if (tickets >= 5)
            {
                discountRate = 0.10;
            }
            else if (tickets >= 3)
            {
                discountRate = 0.05;
            }

            double ticketDiscount = basicCost * discountRate;

            // 10. Calculate child and senior discounts
            double ageDiscount = 0;

            if (age < 12)
            {
                ageDiscount = basicCost * 0.20;
            }
            else if (age >= 60)
            {
                ageDiscount = basicCost * 0.10;
            }

            // 11. Calculate insurance
            double insuranceCost = 0;

            if (chkinsurance.Checked)
            {
                insuranceCost = 25 * tickets;
            }

            // 12. Calculate baggage charge
            // Up to 20 kg per passenger is free
            double freeBaggage = 20 * tickets;
            double excessBaggage = Math.Max(0, baggageWeight - freeBaggage);

            // No excess baggage fee was provided in the rules.
            // Therefore, excess baggage is displayed but not charged.

            // 13. Calculate final cost
            double finalCost = basicCost - ticketDiscount- ageDiscount + insuranceCost;

            if (finalCost < 0)
            {
                finalCost = 0;
            }

            // 14. Display booking information
            lstResult.Items.Clear();

            lstResult.Items.Add("Booking Approved");
            lstResult.Items.Add("Passenger Age: " + age);
            lstResult.Items.Add("Number of Tickets: " + tickets);
            lstResult.Items.Add("Travel Class: " + grbbxtravel.Text);
            lstResult.Items.Add("Baggage Weight: " + baggageWeight + " kg");
            lstResult.Items.Add("Basic Ticket Cost: $" + basicCost.ToString("F2"));
            lstResult.Items.Add("Ticket Discount: $" + ticketDiscount.ToString("F2"));
            lstResult.Items.Add("Age Discount: $" + ageDiscount.ToString("F2"));
            lstResult.Items.Add("Insurance Cost: $" + insuranceCost.ToString("F2"));
            lstResult.Items.Add("Excess Baggage: " + excessBaggage + " kg");
            lstResult.Items.Add("------------------------------");
            lstResult.Items.Add("Final Cost: $" + finalCost.ToString("F2"));
        }

        private void grbbxadditional_Enter(object sender, EventArgs e)
        {

        }

        private void chkinsurance_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

