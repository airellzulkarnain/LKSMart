namespace LKSMart
{
    partial class Profile
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pinError = new System.Windows.Forms.Label();
            this.nameEdit_button = new System.Windows.Forms.Button();
            this.pinEdit_button = new System.Windows.Forms.Button();
            this.birthdayEdit_button = new System.Windows.Forms.Button();
            this.addressEdit_button = new System.Windows.Forms.Button();
            this.genderEdit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.pin_textBox = new System.Windows.Forms.TextBox();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.birthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.upload_button = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.nameError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.27711F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.72289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(411, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backButton_click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 51);
            this.label9.TabIndex = 1;
            this.label9.Text = "PROFILE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.51499F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.48502F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.Controls.Add(this.pinError, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.nameEdit_button, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pinEdit_button, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.birthdayEdit_button, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.addressEdit_button, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.genderEdit_button, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.gender_comboBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.address_textBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.pin_textBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.phoneNumber_textBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.email_textBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.name_textBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.birthday_dateTimePicker, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.nameError, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.205129F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.948718F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.948718F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.205129F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.205129F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.53846F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.717949F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.23077F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(513, 390);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pinError
            // 
            this.pinError.AutoSize = true;
            this.pinError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pinError.ForeColor = System.Drawing.Color.Red;
            this.pinError.Location = new System.Drawing.Point(414, 94);
            this.pinError.Name = "pinError";
            this.pinError.Size = new System.Drawing.Size(96, 32);
            this.pinError.TabIndex = 24;
            // 
            // nameEdit_button
            // 
            this.nameEdit_button.AutoSize = true;
            this.nameEdit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nameEdit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameEdit_button.Location = new System.Drawing.Point(364, 3);
            this.nameEdit_button.Name = "nameEdit_button";
            this.nameEdit_button.Size = new System.Drawing.Size(44, 26);
            this.nameEdit_button.TabIndex = 0;
            this.nameEdit_button.Text = "edit";
            this.nameEdit_button.UseVisualStyleBackColor = true;
            this.nameEdit_button.Click += new System.EventHandler(this.nameEdit_click);
            // 
            // pinEdit_button
            // 
            this.pinEdit_button.AutoSize = true;
            this.pinEdit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pinEdit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pinEdit_button.Location = new System.Drawing.Point(364, 97);
            this.pinEdit_button.Name = "pinEdit_button";
            this.pinEdit_button.Size = new System.Drawing.Size(44, 26);
            this.pinEdit_button.TabIndex = 1;
            this.pinEdit_button.Text = "edit";
            this.pinEdit_button.UseVisualStyleBackColor = true;
            this.pinEdit_button.Click += new System.EventHandler(this.passwordEdit_click);
            // 
            // birthdayEdit_button
            // 
            this.birthdayEdit_button.AutoSize = true;
            this.birthdayEdit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.birthdayEdit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.birthdayEdit_button.Location = new System.Drawing.Point(364, 129);
            this.birthdayEdit_button.Name = "birthdayEdit_button";
            this.birthdayEdit_button.Size = new System.Drawing.Size(44, 26);
            this.birthdayEdit_button.TabIndex = 2;
            this.birthdayEdit_button.Text = "edit";
            this.birthdayEdit_button.UseVisualStyleBackColor = true;
            this.birthdayEdit_button.Click += new System.EventHandler(this.birthdayEdit_click);
            // 
            // addressEdit_button
            // 
            this.addressEdit_button.AutoSize = true;
            this.addressEdit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addressEdit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addressEdit_button.Location = new System.Drawing.Point(364, 161);
            this.addressEdit_button.Name = "addressEdit_button";
            this.addressEdit_button.Size = new System.Drawing.Size(44, 30);
            this.addressEdit_button.TabIndex = 3;
            this.addressEdit_button.Text = "edit";
            this.addressEdit_button.UseVisualStyleBackColor = true;
            this.addressEdit_button.Click += new System.EventHandler(this.addressEdit_click);
            // 
            // genderEdit_button
            // 
            this.genderEdit_button.AutoSize = true;
            this.genderEdit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.genderEdit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderEdit_button.Location = new System.Drawing.Point(364, 244);
            this.genderEdit_button.Name = "genderEdit_button";
            this.genderEdit_button.Size = new System.Drawing.Size(44, 28);
            this.genderEdit_button.TabIndex = 4;
            this.genderEdit_button.Text = "edit";
            this.genderEdit_button.UseVisualStyleBackColor = true;
            this.genderEdit_button.Click += new System.EventHandler(this.genderEdit_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 83);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(3, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(3, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 115);
            this.label8.TabIndex = 12;
            this.label8.Text = "Profile Picture";
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gender_comboBox.Enabled = false;
            this.gender_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Location = new System.Drawing.Point(124, 244);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(234, 28);
            this.gender_comboBox.TabIndex = 13;
            // 
            // address_textBox
            // 
            this.address_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address_textBox.Enabled = false;
            this.address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.address_textBox.Location = new System.Drawing.Point(124, 161);
            this.address_textBox.Multiline = true;
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(234, 77);
            this.address_textBox.TabIndex = 14;
            // 
            // pin_textBox
            // 
            this.pin_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pin_textBox.Enabled = false;
            this.pin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pin_textBox.Location = new System.Drawing.Point(124, 97);
            this.pin_textBox.Name = "pin_textBox";
            this.pin_textBox.PasswordChar = '*';
            this.pin_textBox.Size = new System.Drawing.Size(234, 26);
            this.pin_textBox.TabIndex = 16;
            this.pin_textBox.UseSystemPasswordChar = true;
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumber_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneNumber_textBox.Location = new System.Drawing.Point(124, 35);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.ReadOnly = true;
            this.phoneNumber_textBox.Size = new System.Drawing.Size(234, 26);
            this.phoneNumber_textBox.TabIndex = 17;
            // 
            // email_textBox
            // 
            this.email_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email_textBox.Location = new System.Drawing.Point(124, 66);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.ReadOnly = true;
            this.email_textBox.Size = new System.Drawing.Size(234, 26);
            this.email_textBox.TabIndex = 18;
            // 
            // name_textBox
            // 
            this.name_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_textBox.Enabled = false;
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name_textBox.Location = new System.Drawing.Point(124, 3);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(234, 26);
            this.name_textBox.TabIndex = 19;
            // 
            // birthday_dateTimePicker
            // 
            this.birthday_dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthday_dateTimePicker.Enabled = false;
            this.birthday_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.birthday_dateTimePicker.Location = new System.Drawing.Point(124, 129);
            this.birthday_dateTimePicker.Name = "birthday_dateTimePicker";
            this.birthday_dateTimePicker.Size = new System.Drawing.Size(234, 26);
            this.birthday_dateTimePicker.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.8F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.2F));
            this.tableLayoutPanel3.Controls.Add(this.upload_button, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.profilePicture, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(124, 278);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 109);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // upload_button
            // 
            this.upload_button.AutoSize = true;
            this.upload_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upload_button.BackColor = System.Drawing.Color.Black;
            this.upload_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.upload_button.ForeColor = System.Drawing.Color.White;
            this.upload_button.Location = new System.Drawing.Point(103, 3);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(78, 32);
            this.upload_button.TabIndex = 5;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = false;
            this.upload_button.Click += new System.EventHandler(this.ImageUpload);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.White;
            this.profilePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePicture.Location = new System.Drawing.Point(3, 3);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(94, 103);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 6;
            this.profilePicture.TabStop = false;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(414, 0);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(96, 32);
            this.nameError.TabIndex = 22;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(525, 453);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Profile";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button nameEdit_button;
        private System.Windows.Forms.Button pinEdit_button;
        private System.Windows.Forms.Button birthdayEdit_button;
        private System.Windows.Forms.Button addressEdit_button;
        private System.Windows.Forms.Button genderEdit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox pin_textBox;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.DateTimePicker birthday_dateTimePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label pinError;
    }
}