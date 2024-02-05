using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportStudio
{
    public partial class UserLogin : Form
    {

        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginChoiceBtn_Click(object sender, EventArgs e)
        {
            ToggleRegistration("hide");
        }

        private void RegChoiceBtn_Click(object sender, EventArgs e)
        {
            ToggleRegistration("show");
        }

        private void ToggleRegistration(string operation)
        {
            if (operation == "hide")
            {
                FirstNameLabel.Hide();
                FirstNameInput.Hide();

                LastNameLabel.Hide();
                LastNameInput.Hide();

                StreetLabel.Hide();
                StreetInput.Hide();

                StreetNumberLabel.Hide();
                StreetNumberInput.Hide();

                CityLabel.Hide();
                CityInput.Hide();

                PostalCodeLabel.Hide();
                PostalCodeInput.Hide();

                SubmitBtn.Text = "Anmelden";
            }
            else
            {
                FirstNameLabel.Show();
                FirstNameInput.Show();

                LastNameLabel.Show();
                LastNameInput.Show();

                StreetLabel.Show();
                StreetInput.Show();

                StreetNumberLabel.Show();
                StreetNumberInput.Show();

                CityLabel.Show();
                CityInput.Show();

                PostalCodeLabel.Show();
                PostalCodeInput.Show();

                SubmitBtn.Text = "Registrieren";

            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            handleLogin();
            this.Close();
        }

        private void handleLogin()
        {
            string enteredEmail = EmailInput.Text;
            string enteredPassword = PasswordInput.Text;

            foreach (User user in Form1.users)
            {
                if (user.EMail == enteredEmail && user.Password == enteredPassword)
                {
                    MessageBox.Show($"Welcome, {user.FirstName} {user.LastName}!");
                    // You can perform additional actions or navigate to another form here
                    if(user.IsAdmin)
                    {
                        Form1.adminMode = true;
                        Form1.showLinkDataView();
                    } else
                    {
                        Form1.adminMode = false;
                    }
                    return;
                }
            }

            MessageBox.Show("Invalid login credentials. Please try again.");
        }
    }
}
