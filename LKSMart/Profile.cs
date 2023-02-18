using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class Profile : Form
    {
        private LKSMart_DBDataContext db;
        private Customer _customer;
        public Profile(int customer_id)
        {
            InitializeComponent();
            db = new LKSMart_DBDataContext();
            _customer = (from customer in db.Customers where customer.id == customer_id select customer).First();
            gender_comboBox.Items.Add("Female");
            gender_comboBox.Items.Add("Male");
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            name_textBox.Text = _customer.name;
            phoneNumber_textBox.Text = _customer.phone_number;
            email_textBox.Text = _customer.email;
            pin_textBox.Text = _customer.pin_number;
            birthday_dateTimePicker.Value = _customer.date_of_birth.Value;
            address_textBox.Text = _customer.address;
            gender_comboBox.SelectedItem = _customer.gender;
            profilePicture.Image = Image.FromFile(Helper.GetProfilePicture(_customer.profile_image_name) ?? Helper.GetProfilePicture("default_profile_picture"));
        }

        private void backButton_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameEdit_click(object sender, EventArgs e)
        {
            if (name_textBox.Enabled)
            {
                if (name_textBox.Text.Length > 0)
                {
                    nameError.Text = "";
                    _customer.name = name_textBox.Text;
                    db.SubmitChanges();
                    name_textBox.Enabled = false;
                }
                else
                {
                    nameError.Text = "Name cannot be empty!";
                }
            }
            else
            {
                name_textBox.Enabled = true;
            }
        }

        private void passwordEdit_click(object sender, EventArgs e)
        {
            if (pin_textBox.Enabled)
            {
                if (pin_textBox.Text.Length == 6 && pin_textBox.Text.All(x => "1234567890".Contains(x)))
                {
                    pinError.Text = "";
                    _customer.pin_number = pin_textBox.Text;
                    db.SubmitChanges();
                    pin_textBox.Enabled = false;
                }
                else
                {
                    pinError.Text = "PIN should be 6 digits numeric !";
                }
            }
            else
            {
                pin_textBox.Enabled = true;
            }
        }

        private void birthdayEdit_click(object sender, EventArgs e)
        {
            if (birthday_dateTimePicker.Enabled)
            {
                _customer.date_of_birth = birthday_dateTimePicker.Value;
                db.SubmitChanges();
                birthday_dateTimePicker.Enabled = false;
            }
            else
            {
                birthday_dateTimePicker.Enabled = true;
            }
        }

        private void addressEdit_click(object sender, EventArgs e)
        {
            if (address_textBox.Enabled)
            {
                _customer.address = address_textBox.Text;
                db.SubmitChanges();
                address_textBox.Enabled= false;
            }
            else
            {
                address_textBox.Enabled = true;
            }
        }

        private void genderEdit_click(Object sender, EventArgs e)
        {
            if (gender_comboBox.Enabled)
            {
                _customer.gender = gender_comboBox.SelectedItem.ToString();
                db.SubmitChanges();
                gender_comboBox.Enabled = false;
            }
            else
            {
                gender_comboBox.Enabled = true;
            }
        }
        
        private void ImageUpload(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            Random rand = new Random();
            file.Title = "Select profile picture";
            file.Filter = "JPG Image (*.jpg)|*.jpg|JPEG Image (*.jpeg)|*.jpeg|PNG Image (*.png)|*.png|GIF Image (*.gif)|*.gif";
            if (file.ShowDialog(this) == DialogResult.OK)
            {
                /*if(_customer.profile_image_name != null)
                {
                   Delete previous picture before adding new one to decrease storage usage added later.  
                }*/
                string[] temp = file.FileName.Split('.');
                string ext = temp[temp.Length - 1];
                string destination = "";
                for (int i = 0; i <= 8; i++)
                {
                    string alnum = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    destination += alnum.Substring(rand.Next(alnum.Length), 1);
                }
                File.Copy(file.FileName, Helper.profilePictureDirectory + destination + "." + ext);
                _customer.profile_image_name = destination;
                db.SubmitChanges();
                profilePicture.Image = Image.FromFile(Helper.GetProfilePicture(_customer.profile_image_name) ?? Helper.GetProfilePicture("default_profile_picture"));
            }
        }
    }
}
