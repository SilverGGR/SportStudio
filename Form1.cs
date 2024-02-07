using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SportStudio
{
    public partial class Form1 : Form
    {
        public static List<User> users = new List<User>();
        public static List<Admin> admins = new List<Admin>();
        public static User? activUser;
        public static Admin? activeAdmin;
        User user1;
        User user2;
        User user3;
        User user4;
        User user5;
        User user6;
        Admin admin;

        public Form1()
        {
            InitializeComponent();

            user1 = new User("johannes@outlook.com", "jg", "Johannes", "Gabrielsen", "Bechtleweg", 21, "Heilbronn", 74076);
            user2 = new User("ruven@outlook.com", "rr", "Ruven", "Radicke", "Kleiner Bechtleweg", 69, "Schwabbach", 79009);
            user3 = new User("marc@outlook.com", "mm", "Marc", "Meister", "Großer Bechtleweg", 99, "Heilbronn", 74078);
            user4 = new User("luis@outlook.com", "lh", "Luis", "Höpfner", "Großer Bechtleweg", 77, "Heilbronn", 74078);
            user5 = new User("kadir@outlook.com", "kö", "Kadir", "Özcan", "Bechtlegasse", 12, "Heilbronn", 74074);
            user6 = new User("felix@outlook.com", "fu", "Felix", "Ulmer", "Bechtlestraße", 99, "Neckarsulm", 74002);
            admin = new Admin("admin@outlook.com", "admin", "Admin the Plug");
            admins.Add(admin);
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);
        }

        public User? ActiveUser
        {
            get { return activUser; }
            set { activUser = value; }
        }

        public List<User> UsersList
        {
            get { return users; }
        }

        public Admin? ActiveAdmin
        {
            get { return activeAdmin; }
            set { activeAdmin = value; }
        }
        public List<Admin> AdminsList
        {
            get { return admins; }
        }
        public void showLinkDataView(bool show)
        {
            if (show)
            {
                linkDataView.Visible = true;
            }
            else
            {
                linkDataView.Visible = false;
            }
        }

        private void buttonMuki_Click(object sender, EventArgs e)
        {
            labelMitgliederMuki.Text = "";
            panelMuki.Visible = true;
            foreach (User user in users)
            {
                if (user.UserMembership.MukiAbo == true)
                {
                    if (labelMitgliederMuki.Text == "")
                    {
                        labelMitgliederMuki.Text = user.FirstName + " " + user.LastName;
                    }
                    else
                    {
                        labelMitgliederMuki.Text = labelMitgliederMuki.Text + ", " + user.FirstName + " " + user.LastName;
                    }
                }
            }
        }

        private void buttonWellness_Click(object sender, EventArgs e)
        {
            labelMitgliederWellness.Text = "";
            panelWellness.Visible = true;
            foreach (User user in users)
            {
                if (user.UserMembership.WellnessAbo == true)
                {
                    if (labelMitgliederWellness.Text == "")
                    {
                        labelMitgliederWellness.Text = user.FirstName + " " + user.LastName;
                    }
                    else
                    {
                        labelMitgliederWellness.Text = labelMitgliederWellness.Text + ", " + user.FirstName + " " + user.LastName;
                    }
                }
            }
        }

        private void buttonCardio_Click(object sender, EventArgs e)
        {
            labelMitgliederCardio.Text = "";
            panelCardio.Visible = true;
            foreach (User user in users)
            {
                if (user.UserMembership.CardioAbo == true)
                {
                    if (labelMitgliederCardio.Text == "")
                    {
                        labelMitgliederCardio.Text = user.FirstName + " " + user.LastName;
                    }
                    else
                    {
                        labelMitgliederCardio.Text = labelMitgliederCardio.Text + ", " + user.FirstName + " " + user.LastName;
                    }
                }
            }
        }

        private void buttonWasser_Click(object sender, EventArgs e)
        {
            labelMitgliederWasser.Text = "";
            panelWasser.Visible = true;
            foreach (User user in users)
            {
                if (user.UserMembership.WasserAbo == true)
                {
                    if (labelMitgliederWasser.Text == "")
                    {
                        labelMitgliederWasser.Text = user.FirstName + " " + user.LastName;
                    }
                    else
                    {
                        labelMitgliederWasser.Text = labelMitgliederWasser.Text + ", " + user.FirstName + " " + user.LastName;
                    }
                }
            }
        }

        private void linkAbo_Click(object sender, EventArgs e)
        {
            if (activUser != null)
            {
                new AboScreen(this).ShowDialog();
            }
            else
            {
                new UserLogin(this).ShowDialog();
            }
        }

        private void mukiBackButton_Click(object sender, EventArgs e)
        {
            panelMuki.Visible = false;
        }

        private void wasserBackButton_Click(object sender, EventArgs e)
        {
            panelWasser.Visible = false;
        }

        private void cardioBackButton_Click(object sender, EventArgs e)
        {
            panelCardio.Visible = false;
        }

        private void wellnessBackButton_Click(object sender, EventArgs e)
        {
            panelWellness.Visible = false;
        }

        private void linkAnmeldung_Click(object sender, EventArgs e)
        {
            new UserLogin(this).ShowDialog();
        }

        private void linkDataView_Click(object sender, EventArgs e)
        {
            new UserDataView().ShowDialog();
        }
    }
}