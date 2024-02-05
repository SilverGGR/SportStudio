using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SportStudio
{
    public partial class Form1 : Form
    {
        public static bool adminMode = false;
        public static List<User> users = new List<User>();
        Address address1 = new Address("Tomstraﬂe", 21, "Tomstadt", 11223);
        User user1;

        public Form1()
        {
            InitializeComponent();

            user1 = new User("Tom", "Lumpe", "tom@outlook.com", "tomspasswort", true, address1);
            users.Add(user1);
            MessageBox.Show(user1.FirstName);
            foreach (User user in users)
            {
                MessageBox.Show($"Benutzer: {user.FirstName} {user.LastName}\nEmail: {user.EMail}\nStraﬂe: {user.Address.Street}\nHausnummer: {user.Address.StreetNumber}");
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
            new AboScreen().ShowDialog();
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
            new UserLogin().ShowDialog();
        }

        private void DataViewLabel_Click(object sender, EventArgs e)
        {
            new DataView().ShowDialog();
        }
    }
}