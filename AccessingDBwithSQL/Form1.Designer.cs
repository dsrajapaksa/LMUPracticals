namespace AccessingDBwithSQL
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
            System.Windows.Forms.Label e_idLabel;
            System.Windows.Forms.Label dept_idLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label dateOFJoinLabel;
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.e_idTextBox = new System.Windows.Forms.TextBox();
            this.dept_idTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.dateOFJoinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            e_idLabel = new System.Windows.Forms.Label();
            dept_idLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            dateOFJoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // e_idLabel
            // 
            e_idLabel.AutoSize = true;
            e_idLabel.Location = new System.Drawing.Point(34, 304);
            e_idLabel.Name = "e_idLabel";
            e_idLabel.Size = new System.Drawing.Size(27, 13);
            e_idLabel.TabIndex = 22;
            e_idLabel.Text = "e id:";
            // 
            // dept_idLabel
            // 
            dept_idLabel.AutoSize = true;
            dept_idLabel.Location = new System.Drawing.Point(34, 330);
            dept_idLabel.Name = "dept_idLabel";
            dept_idLabel.Size = new System.Drawing.Size(42, 13);
            dept_idLabel.TabIndex = 24;
            dept_idLabel.Text = "dept id:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(34, 356);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 26;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(34, 382);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 28;
            lastNameLabel.Text = "Last Name:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(34, 408);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 30;
            sexLabel.Text = "Sex:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(34, 434);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 32;
            addressLabel.Text = "Address:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(34, 460);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 34;
            ageLabel.Text = "Age:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(34, 486);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(39, 13);
            salaryLabel.TabIndex = 36;
            salaryLabel.Text = "Salary:";
            // 
            // dateOFJoinLabel
            // 
            dateOFJoinLabel.AutoSize = true;
            dateOFJoinLabel.Location = new System.Drawing.Point(34, 513);
            dateOFJoinLabel.Name = "dateOFJoinLabel";
            dateOFJoinLabel.Size = new System.Drawing.Size(69, 13);
            dateOFJoinLabel.TabIndex = 38;
            dateOFJoinLabel.Text = "Date OFJoin:";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(947, 235);
            this.employeeDataGridView.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // e_idTextBox
            // 
            this.e_idTextBox.Location = new System.Drawing.Point(109, 301);
            this.e_idTextBox.Name = "e_idTextBox";
            this.e_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.e_idTextBox.TabIndex = 23;
            // 
            // dept_idTextBox
            // 
            this.dept_idTextBox.Location = new System.Drawing.Point(109, 327);
            this.dept_idTextBox.Name = "dept_idTextBox";
            this.dept_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.dept_idTextBox.TabIndex = 25;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(109, 353);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 27;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(109, 379);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 29;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Location = new System.Drawing.Point(109, 405);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexTextBox.TabIndex = 31;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(109, 431);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 33;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(109, 457);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 20);
            this.ageTextBox.TabIndex = 35;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(109, 483);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.salaryTextBox.TabIndex = 37;
            // 
            // dateOFJoinDateTimePicker
            // 
            this.dateOFJoinDateTimePicker.Location = new System.Drawing.Point(109, 509);
            this.dateOFJoinDateTimePicker.Name = "dateOFJoinDateTimePicker";
            this.dateOFJoinDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOFJoinDateTimePicker.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 557);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(e_idLabel);
            this.Controls.Add(this.e_idTextBox);
            this.Controls.Add(dept_idLabel);
            this.Controls.Add(this.dept_idTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(dateOFJoinLabel);
            this.Controls.Add(this.dateOFJoinDateTimePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox e_idTextBox;
        private System.Windows.Forms.TextBox dept_idTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.DateTimePicker dateOFJoinDateTimePicker;
    }
}

