using System.CodeDom;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SportStudio
{
    public partial class Form1 : Form
    {
        public static List<User> users = new List<User>();
        public static User? activUser;
        User user1;
        User user2;
        User user3;

        UserLogin userlogin;

        public Form1()
        {
            InitializeComponent();

            user1 = new User("Johannes", "Gabrielsen", "johannes@outlook.com", "jg", true, "Bechtleweg", 21, "Heilbronn", 74076);
            user2 = new User("Ruven", "Radicke", "ruven@outlook.com", "rr", true, "Kleiner Bechtleweg", 69, "Schwabbach", 79009);
            user3 = new User("Marc", "Meister", "marc@outlook.com", "mm", false, "Groﬂer Bechtleweg", 99, "Heilbronn", 74078);
            users.Add(user1);
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
        public void showLinkDataView()
        {
            linkDataView.Visible = false;
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
        }
    }
}