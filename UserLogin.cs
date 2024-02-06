using Microsoft.VisualBasic.ApplicationServices;
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
        List<User> users = new List<User>();
        List<Admin> admins = new List<Admin>();

        private Form1 f1;

        public UserLogin(Form1 f)
        {
            this.f1 = f;
            InitializeComponent();

            users = f1.UsersList;
            admins = f1.AdminsList;
            if (f1.ActiveUser != null)
            {
                loggedState(false);
            }

            StreetNumberInput.KeyPress += allowOnlyNumbers;
            PostalCodeInput.KeyPress += allowOnlyNumbers;
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
                clearText();
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
                clearText();
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (SubmitBtn.Text == "Anmelden")
            {
                handleLogin();
            }
            else
            {
                handleRegister();
            }
        }

        private void handleRegister()
        {
            if (FirstNameInput.Text == "" || LastNameInput.Text == "" || EmailInput.Text == "" || PasswordInput.Text == "" || StreetInput.Text == "" || StreetNumberInput.Text == "" || CityInput.Text == "" || PostalCodeInput.Text == "")
            {
                MessageBox.Show("Bitte füllen sie alle Felder aus");
            }
            else
            {
                User user = new User(EmailInput.Text, PasswordInput.Text, FirstNameInput.Text, LastNameInput.Text, StreetInput.Text, int.Parse(StreetNumberInput.Text), CityInput.Text, int.Parse(PostalCodeInput.Text));
                users.Add(user);
                MessageBox.Show($"Welcome, {user.FirstName} {user.LastName}!");
                f1.ActiveUser = user;

                loggedState(false);
            }
        }
        private void handleLogin()
        {
            string enteredEmail = EmailInput.Text;
            string enteredPassword = PasswordInput.Text;

            foreach (User user in users)
            {
                if (user.Email == enteredEmail && user.Password == enteredPassword)
                {
                    MessageBox.Show($"Welcome, {user.FirstName} {user.LastName}!");
                    f1.ActiveUser = user;

                    loggedState(false);
                    return;
                }
            }
            foreach (Admin admin in admins)
            {
                if (admin.Email == enteredEmail && admin.Password == enteredPassword)
                {
                    MessageBox.Show("Willkommen werter Herr Admin!");
                    f1.ActiveAdmin = admin;
                    f1.showLinkDataView(true);
                    loggedState(false);
                    return;
                }
            }

            MessageBox.Show("Invalid login credentials. Please try again.");
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            loggedState(true);
        }

        private void loggedState(bool logout)
        {
            if (logout)
            {
                f1.ActiveUser = null;
                buttonLogOut.Visible = false;
                label2.Visible = false;
                labelLoggedName.Visible = false;

                panel1.Visible = true;
                LoginChoiceBtn.Visible = true;
                RegChoiceBtn.Visible = true;
            }
            else
            {
                buttonLogOut.Visible = true;
                label2.Visible = true;
                labelLoggedName.Visible = true;
                if (f1.ActiveUser != null)
                {
                    labelLoggedName.Text = f1.ActiveUser.FirstName;
                } else
                {
                    labelLoggedName.Text = f1.ActiveAdmin.FirstName;
                }


                panel1.Visible = false;
                LoginChoiceBtn.Visible = false;
                RegChoiceBtn.Visible = false;
                clearText();
            }
        }

        private void clearText()
        {
            FirstNameInput.Text = "";
            LastNameInput.Text = "";
            EmailInput.Text = "";
            PasswordInput.Text = "";
            StreetInput.Text = "";
            StreetNumberInput.Text = "";
            CityInput.Text = "";
            PostalCodeInput.Text = "";
        }

        private void allowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
