namespace Vehicle_Rental_Management_System
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.lblexperience = new System.Windows.Forms.Label();
            this.grbbxcustomer = new System.Windows.Forms.GroupBox();
            this.grbbxvehicle = new System.Windows.Forms.GroupBox();
            this.rdoLuxury = new System.Windows.Forms.RadioButton();
            this.rdoSuv = new System.Windows.Forms.RadioButton();
            this.rdoecomy = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbbxinsurance = new System.Windows.Forms.GroupBox();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnClerar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbbxrental = new System.Windows.Forms.GroupBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.grbbxcustomer.SuspendLayout();
            this.grbbxvehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbbxinsurance.SuspendLayout();
            this.grbbxrental.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(51, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAge.Location = new System.Drawing.Point(57, 73);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(96, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Customer Age";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldays.Location = new System.Drawing.Point(29, 120);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(152, 16);
            this.lbldays.TabIndex = 2;
            this.lbldays.Text = "Number of Rental Days";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(208, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(208, 66);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 4;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(208, 120);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 22);
            this.txtDays.TabIndex = 5;
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(208, 172);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(100, 22);
            this.txtExperience.TabIndex = 6;
            // 
            // lblexperience
            // 
            this.lblexperience.AutoSize = true;
            this.lblexperience.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblexperience.Location = new System.Drawing.Point(14, 172);
            this.lblexperience.Name = "lblexperience";
            this.lblexperience.Size = new System.Drawing.Size(182, 16);
            this.lblexperience.TabIndex = 7;
            this.lblexperience.Text = "Yeras of Driving Experience";
            // 
            // grbbxcustomer
            // 
            this.grbbxcustomer.Controls.Add(this.lblName);
            this.grbbxcustomer.Controls.Add(this.lblexperience);
            this.grbbxcustomer.Controls.Add(this.lblAge);
            this.grbbxcustomer.Controls.Add(this.txtExperience);
            this.grbbxcustomer.Controls.Add(this.lbldays);
            this.grbbxcustomer.Controls.Add(this.txtDays);
            this.grbbxcustomer.Controls.Add(this.txtName);
            this.grbbxcustomer.Controls.Add(this.txtAge);
            this.grbbxcustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbxcustomer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbbxcustomer.Location = new System.Drawing.Point(12, 12);
            this.grbbxcustomer.Name = "grbbxcustomer";
            this.grbbxcustomer.Size = new System.Drawing.Size(394, 208);
            this.grbbxcustomer.TabIndex = 8;
            this.grbbxcustomer.TabStop = false;
            this.grbbxcustomer.Text = "Customer Information";
            // 
            // grbbxvehicle
            // 
            this.grbbxvehicle.Controls.Add(this.rdoLuxury);
            this.grbbxvehicle.Controls.Add(this.rdoSuv);
            this.grbbxvehicle.Controls.Add(this.rdoecomy);
            this.grbbxvehicle.Controls.Add(this.pictureBox3);
            this.grbbxvehicle.Controls.Add(this.pictureBox2);
            this.grbbxvehicle.Controls.Add(this.pictureBox1);
            this.grbbxvehicle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbxvehicle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbbxvehicle.Location = new System.Drawing.Point(12, 238);
            this.grbbxvehicle.Name = "grbbxvehicle";
            this.grbbxvehicle.Size = new System.Drawing.Size(394, 142);
            this.grbbxvehicle.TabIndex = 9;
            this.grbbxvehicle.TabStop = false;
            this.grbbxvehicle.Text = "Vehicle Type";
            // 
            // rdoLuxury
            // 
            this.rdoLuxury.AutoSize = true;
            this.rdoLuxury.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoLuxury.Location = new System.Drawing.Point(277, 34);
            this.rdoLuxury.Name = "rdoLuxury";
            this.rdoLuxury.Size = new System.Drawing.Size(63, 18);
            this.rdoLuxury.TabIndex = 13;
            this.rdoLuxury.TabStop = true;
            this.rdoLuxury.Text = "Luxury";
            this.rdoLuxury.UseVisualStyleBackColor = true;
            // 
            // rdoSuv
            // 
            this.rdoSuv.AutoSize = true;
            this.rdoSuv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoSuv.Location = new System.Drawing.Point(135, 34);
            this.rdoSuv.Name = "rdoSuv";
            this.rdoSuv.Size = new System.Drawing.Size(45, 18);
            this.rdoSuv.TabIndex = 12;
            this.rdoSuv.TabStop = true;
            this.rdoSuv.Text = "Suv";
            this.rdoSuv.UseVisualStyleBackColor = true;
            // 
            // rdoecomy
            // 
            this.rdoecomy.AutoSize = true;
            this.rdoecomy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoecomy.Location = new System.Drawing.Point(6, 34);
            this.rdoecomy.Name = "rdoecomy";
            this.rdoecomy.Size = new System.Drawing.Size(61, 18);
            this.rdoecomy.TabIndex = 11;
            this.rdoecomy.TabStop = true;
            this.rdoecomy.Text = "Ecomy";
            this.rdoecomy.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Vehicle_Rental_Management_System.Properties.Resources.Toyota_Corolla_Cross_2023;
            this.pictureBox3.Image = global::Vehicle_Rental_Management_System.Properties.Resources.Toyota_Corolla_Cross_2023;
            this.pictureBox3.Location = new System.Drawing.Point(268, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Vehicle_Rental_Management_System.Properties.Resources.Toyota_Corolla_Cross__2022_;
            this.pictureBox2.Image = global::Vehicle_Rental_Management_System.Properties.Resources.Toyota_Corolla_Cross__2022_;
            this.pictureBox2.Location = new System.Drawing.Point(135, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vehicle_Rental_Management_System.Properties.Resources._1f65e7cac36f124e58177ff7f857f151;
            this.pictureBox1.Image = global::Vehicle_Rental_Management_System.Properties.Resources._1f65e7cac36f124e58177ff7f857f1511;
            this.pictureBox1.Location = new System.Drawing.Point(18, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grbbxinsurance
            // 
            this.grbbxinsurance.Controls.Add(this.chkinsurance);
            this.grbbxinsurance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbxinsurance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbbxinsurance.Location = new System.Drawing.Point(12, 386);
            this.grbbxinsurance.Name = "grbbxinsurance";
            this.grbbxinsurance.Size = new System.Drawing.Size(394, 67);
            this.grbbxinsurance.TabIndex = 10;
            this.grbbxinsurance.TabStop = false;
            this.grbbxinsurance.Text = "Insurance Option";
            this.grbbxinsurance.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkinsurance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkinsurance.Location = new System.Drawing.Point(54, 29);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(248, 20);
            this.chkinsurance.TabIndex = 0;
            this.chkinsurance.Text = "Add Insurance Option($ 15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btncalculate.Location = new System.Drawing.Point(234, 471);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(98, 40);
            this.btncalculate.TabIndex = 11;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnClerar
            // 
            this.btnClerar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClerar.Location = new System.Drawing.Point(374, 471);
            this.btnClerar.Name = "btnClerar";
            this.btnClerar.Size = new System.Drawing.Size(95, 40);
            this.btnClerar.TabIndex = 12;
            this.btnClerar.Text = "Clear";
            this.btnClerar.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(525, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grbbxrental
            // 
            this.grbbxrental.Controls.Add(this.lstResult);
            this.grbbxrental.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbxrental.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbbxrental.Location = new System.Drawing.Point(466, 26);
            this.grbbxrental.Name = "grbbxrental";
            this.grbbxrental.Size = new System.Drawing.Size(298, 406);
            this.grbbxrental.TabIndex = 14;
            this.grbbxrental.TabStop = false;
            this.grbbxrental.Text = "Rental Information and Results";
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Items.AddRange(new object[] {
            "Rental Details"});
            this.lstResult.Location = new System.Drawing.Point(19, 33);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(251, 340);
            this.lstResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.grbbxrental);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClerar);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.grbbxinsurance);
            this.Controls.Add(this.grbbxvehicle);
            this.Controls.Add(this.grbbxcustomer);
            this.Name = "Form1";
            this.Text = "Vehicle Rental Management System ";
            this.grbbxcustomer.ResumeLayout(false);
            this.grbbxcustomer.PerformLayout();
            this.grbbxvehicle.ResumeLayout(false);
            this.grbbxvehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbbxinsurance.ResumeLayout(false);
            this.grbbxinsurance.PerformLayout();
            this.grbbxrental.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Label lblexperience;
        private System.Windows.Forms.GroupBox grbbxcustomer;
        private System.Windows.Forms.GroupBox grbbxvehicle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rdoLuxury;
        private System.Windows.Forms.RadioButton rdoSuv;
        private System.Windows.Forms.RadioButton rdoecomy;
        private System.Windows.Forms.GroupBox grbbxinsurance;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnClerar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbbxrental;
        private System.Windows.Forms.ListBox lstResult;
    }
}

