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
        Admin admin;

        public Form1()
        {
            InitializeComponent();

            user1 = new User("johannes@outlook.com", "jg", "Johannes", "Gabrielsen", "Bechtleweg", 21, "Heilbronn", 74076);
            user2 = new User("ruven@outlook.com", "rr", "Ruven", "Radicke", "Kleiner Bechtleweg", 69, "Schwabbach", 79009);
            user3 = new User("marc@outlook.com", "mm", "Marc", "Meister",  "Groﬂer Bechtleweg", 99, "Heilbronn", 74078);
            admin = new Admin("g", "g", "AdminGuy");
            admins.Add(admin);
            activUser = user1;
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
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
            } else
            {
                linkDataView.Visible = false;
            }
        }

        private void buttonMuki_Click(object sender, EventArgs e)
        {
            panelMuki.Visible = true;
        }

        private void buttonWellness_Click(object sender, EventArgs e)
        {
            panelWellness.Visible = true;
        }

        private void buttonCardio_Click(object sender, EventArgs e)
        {
            panelCardio.Visible = true;
        }

        private void buttonWasser_Click(object sender, EventArgs e)
        {
            panelWasser.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(activUser.UserMembership.MukiAbo.ToString());
            activUser.ShowAttributes();
        }
    }
}