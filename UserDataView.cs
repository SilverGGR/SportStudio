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
    public partial class UserDataView : Form
    {
        public UserDataView()
        {
            InitializeComponent();
            userBindingSource.DataSource = Form1.users;
            membershipBindingSource.DataSource = Form1.users.Select(u => u.UserMembership).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Durch das drücken eines Buttons wird hier lediglich der letzte Bearbeitungsvorgang übernommen daher ist hier keine Methode nötig 
            // Sieht auch bissle schöner aus, wenn man auf einen Button drückt :D
        }
    }
}
