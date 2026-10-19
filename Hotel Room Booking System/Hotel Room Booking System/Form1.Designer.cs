namespace Hotel_Room_Booking_System
{
    partial class HotelBooking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNmrofGuest = new System.Windows.Forms.Label();
            this.lblNmrofNights = new System.Windows.Forms.Label();
            this.lblGstAge = new System.Windows.Forms.Label();
            this.lblGstName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnHight = new System.Windows.Forms.RadioButton();
            this.radioBtnNormal = new System.Windows.Forms.RadioButton();
            this.radioBtnStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxBreakFast = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGuest);
            this.groupBox1.Controls.Add(this.txtNights);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblNmrofGuest);
            this.groupBox1.Controls.Add(this.lblNmrofNights);
            this.groupBox1.Controls.Add(this.lblGstAge);
            this.groupBox1.Controls.Add(this.lblGstName);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtGuest
            // 
            this.txtGuest.Location = new System.Drawing.Point(215, 185);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(151, 22);
            this.txtGuest.TabIndex = 7;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(215, 130);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(151, 22);
            this.txtNights.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(215, 78);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(151, 22);
            this.txtAge.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 22);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNmrofGuest
            // 
            this.lblNmrofGuest.AutoSize = true;
            this.lblNmrofGuest.Location = new System.Drawing.Point(56, 191);
            this.lblNmrofGuest.Name = "lblNmrofGuest";
            this.lblNmrofGuest.Size = new System.Drawing.Size(117, 16);
            this.lblNmrofGuest.TabIndex = 3;
            this.lblNmrofGuest.Text = "Number of Guest:";
            // 
            // lblNmrofNights
            // 
            this.lblNmrofNights.AutoSize = true;
            this.lblNmrofNights.Location = new System.Drawing.Point(54, 136);
            this.lblNmrofNights.Name = "lblNmrofNights";
            this.lblNmrofNights.Size = new System.Drawing.Size(120, 16);
            this.lblNmrofNights.TabIndex = 2;
            this.lblNmrofNights.Text = "Number of Nights:";
            // 
            // lblGstAge
            // 
            this.lblGstAge.AutoSize = true;
            this.lblGstAge.Location = new System.Drawing.Point(76, 84);
            this.lblGstAge.Name = "lblGstAge";
            this.lblGstAge.Size = new System.Drawing.Size(76, 16);
            this.lblGstAge.TabIndex = 1;
            this.lblGstAge.Text = "Guest Age:";
            // 
            // lblGstName
            // 
            this.lblGstName.AutoSize = true;
            this.lblGstName.Location = new System.Drawing.Point(70, 32);
            this.lblGstName.Name = "lblGstName";
            this.lblGstName.Size = new System.Drawing.Size(88, 16);
            this.lblGstName.TabIndex = 0;
            this.lblGstName.Text = "Guest Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnHight);
            this.groupBox2.Controls.Add(this.radioBtnNormal);
            this.groupBox2.Controls.Add(this.radioBtnStandard);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // radioBtnHight
            // 
            this.radioBtnHight.AutoSize = true;
            this.radioBtnHight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnHight.Location = new System.Drawing.Point(293, 34);
            this.radioBtnHight.Name = "radioBtnHight";
            this.radioBtnHight.Size = new System.Drawing.Size(58, 20);
            this.radioBtnHight.TabIndex = 2;
            this.radioBtnHight.TabStop = true;
            this.radioBtnHight.Text = "Hight";
            this.radioBtnHight.UseVisualStyleBackColor = true;
            // 
            // radioBtnNormal
            // 
            this.radioBtnNormal.AutoSize = true;
            this.radioBtnNormal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNormal.Location = new System.Drawing.Point(136, 34);
            this.radioBtnNormal.Name = "radioBtnNormal";
            this.radioBtnNormal.Size = new System.Drawing.Size(71, 20);
            this.radioBtnNormal.TabIndex = 1;
            this.radioBtnNormal.TabStop = true;
            this.radioBtnNormal.Text = "Normal";
            this.radioBtnNormal.UseVisualStyleBackColor = true;
            // 
            // radioBtnStandard
            // 
            this.radioBtnStandard.AutoSize = true;
            this.radioBtnStandard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnStandard.Location = new System.Drawing.Point(27, 34);
            this.radioBtnStandard.Name = "radioBtnStandard";
            this.radioBtnStandard.Size = new System.Drawing.Size(83, 20);
            this.radioBtnStandard.TabIndex = 0;
            this.radioBtnStandard.TabStop = true;
            this.radioBtnStandard.Text = "Standard";
            this.radioBtnStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxBreakFast);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional Options";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // checkBoxBreakFast
            // 
            this.checkBoxBreakFast.AutoSize = true;
            this.checkBoxBreakFast.Location = new System.Drawing.Point(34, 31);
            this.checkBoxBreakFast.Name = "checkBoxBreakFast";
            this.checkBoxBreakFast.Size = new System.Drawing.Size(239, 20);
            this.checkBoxBreakFast.TabIndex = 0;
            this.checkBoxBreakFast.Text = "BreakFar(10 Per Guest per nights)";
            this.checkBoxBreakFast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(109, 442);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 37);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(292, 442);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 37);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(467, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Items.AddRange(new object[] {
            "Booking Details"});
            this.lstResult.Location = new System.Drawing.Point(514, 15);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(274, 303);
            this.lstResult.TabIndex = 8;
            // 
            // HotelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HotelBooking";
            this.Text = "HotelBooking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGstName;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNmrofGuest;
        private System.Windows.Forms.Label lblNmrofNights;
        private System.Windows.Forms.Label lblGstAge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnStandard;
        private System.Windows.Forms.RadioButton radioBtnHight;
        private System.Windows.Forms.RadioButton radioBtnNormal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxBreakFast;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstResult;
    }
}

