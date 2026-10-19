namespace Airline_Ticket_Booking_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbbxpersonal = new System.Windows.Forms.GroupBox();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblPassengerAge = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.grbbxtravel = new System.Windows.Forms.GroupBox();
            this.rdofirst = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.rdobsness = new System.Windows.Forms.RadioButton();
            this.grbbxadditional = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.btncal = new System.Windows.Forms.Button();
            this.btncler = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.grbbxpersonal.SuspendLayout();
            this.grbbxtravel.SuspendLayout();
            this.grbbxadditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbbxpersonal
            // 
            this.grbbxpersonal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbbxpersonal.Controls.Add(this.txtBaggageWeight);
            this.grbbxpersonal.Controls.Add(this.txtTickets);
            this.grbbxpersonal.Controls.Add(this.txtPassengerAge);
            this.grbbxpersonal.Controls.Add(this.txtPassengerName);
            this.grbbxpersonal.Controls.Add(this.label4);
            this.grbbxpersonal.Controls.Add(this.lblTickets);
            this.grbbxpersonal.Controls.Add(this.lblPassengerAge);
            this.grbbxpersonal.Controls.Add(this.lblPassengerName);
            this.grbbxpersonal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbxpersonal.Location = new System.Drawing.Point(12, 12);
            this.grbbxpersonal.Name = "grbbxpersonal";
            this.grbbxpersonal.Size = new System.Drawing.Size(414, 220);
            this.grbbxpersonal.TabIndex = 0;
            this.grbbxpersonal.TabStop = false;
            this.grbbxpersonal.Text = "Personal Information";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(77, 33);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(118, 16);
            this.lblPassengerName.TabIndex = 0;
            this.lblPassengerName.Text = "Passenger Name:";
            // 
            // lblPassengerAge
            // 
            this.lblPassengerAge.AutoSize = true;
            this.lblPassengerAge.Location = new System.Drawing.Point(83, 71);
            this.lblPassengerAge.Name = "lblPassengerAge";
            this.lblPassengerAge.Size = new System.Drawing.Size(106, 16);
            this.lblPassengerAge.TabIndex = 1;
            this.lblPassengerAge.Text = "Passenger Age:";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(74, 124);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(125, 16);
            this.lblTickets.TabIndex = 2;
            this.lblTickets.Text = "Number of Tickets:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Baggage Weight(kg):";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(218, 33);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(153, 22);
            this.txtPassengerName.TabIndex = 4;
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(218, 80);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(153, 22);
            this.txtPassengerAge.TabIndex = 5;
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(218, 124);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(153, 22);
            this.txtTickets.TabIndex = 6;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(218, 167);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(153, 22);
            this.txtBaggageWeight.TabIndex = 7;
            // 
            // grbbxtravel
            // 
            this.grbbxtravel.Controls.Add(this.rdobsness);
            this.grbbxtravel.Controls.Add(this.rdonormal);
            this.grbbxtravel.Controls.Add(this.rdofirst);
            this.grbbxtravel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbxtravel.Location = new System.Drawing.Point(12, 238);
            this.grbbxtravel.Name = "grbbxtravel";
            this.grbbxtravel.Size = new System.Drawing.Size(414, 100);
            this.grbbxtravel.TabIndex = 1;
            this.grbbxtravel.TabStop = false;
            this.grbbxtravel.Text = "Travel Class";
            // 
            // rdofirst
            // 
            this.rdofirst.AutoSize = true;
            this.rdofirst.Location = new System.Drawing.Point(6, 55);
            this.rdofirst.Name = "rdofirst";
            this.rdofirst.Size = new System.Drawing.Size(89, 20);
            this.rdofirst.TabIndex = 0;
            this.rdofirst.TabStop = true;
            this.rdofirst.Text = "First Class";
            this.rdofirst.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Location = new System.Drawing.Point(128, 55);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(108, 20);
            this.rdonormal.TabIndex = 1;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Normal Class";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // rdobsness
            // 
            this.rdobsness.AutoSize = true;
            this.rdobsness.Location = new System.Drawing.Point(265, 55);
            this.rdobsness.Name = "rdobsness";
            this.rdobsness.Size = new System.Drawing.Size(123, 20);
            this.rdobsness.TabIndex = 2;
            this.rdobsness.TabStop = true;
            this.rdobsness.Text = "Bussiness Class";
            this.rdobsness.UseVisualStyleBackColor = true;
            // 
            // grbbxadditional
            // 
            this.grbbxadditional.Controls.Add(this.chkinsurance);
            this.grbbxadditional.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbxadditional.Location = new System.Drawing.Point(12, 344);
            this.grbbxadditional.Name = "grbbxadditional";
            this.grbbxadditional.Size = new System.Drawing.Size(414, 45);
            this.grbbxadditional.TabIndex = 2;
            this.grbbxadditional.TabStop = false;
            this.grbbxadditional.Text = "Additional Options";
            this.grbbxadditional.Enter += new System.EventHandler(this.grbbxadditional_Enter);
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Location = new System.Drawing.Point(32, 19);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(253, 20);
            this.chkinsurance.TabIndex = 0;
            this.chkinsurance.Text = "Add Travel Insurace($25 Per Ticket):";
            this.chkinsurance.UseVisualStyleBackColor = true;
            this.chkinsurance.CheckedChanged += new System.EventHandler(this.chkinsurance_CheckedChanged);
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(262, 395);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(121, 43);
            this.btncal.TabIndex = 3;
            this.btncal.Text = "Calculate";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btncler
            // 
            this.btncler.Location = new System.Drawing.Point(427, 395);
            this.btncler.Name = "btncler";
            this.btncler.Size = new System.Drawing.Size(123, 43);
            this.btncler.TabIndex = 4;
            this.btncler.Text = "Clear";
            this.btncler.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(594, 395);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(123, 43);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Items.AddRange(new object[] {
            "Airline Booking Details"});
            this.lstResult.Location = new System.Drawing.Point(483, 33);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(281, 290);
            this.lstResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncler);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.grbbxadditional);
            this.Controls.Add(this.grbbxtravel);
            this.Controls.Add(this.grbbxpersonal);
            this.Name = "Form1";
            this.Text = "Airline Booking Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbbxpersonal.ResumeLayout(false);
            this.grbbxpersonal.PerformLayout();
            this.grbbxtravel.ResumeLayout(false);
            this.grbbxtravel.PerformLayout();
            this.grbbxadditional.ResumeLayout(false);
            this.grbbxadditional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbbxpersonal;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblPassengerAge;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.GroupBox grbbxtravel;
        private System.Windows.Forms.RadioButton rdobsness;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.RadioButton rdofirst;
        private System.Windows.Forms.GroupBox grbbxadditional;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btncler;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox lstResult;
    }
}

