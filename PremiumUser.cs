using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    internal class PremiumUser : User
    {
        public PremiumUser(string firstName, string lastName, string email, string password, bool isAdmin, string street, int streetNumber, string city, int postalCode) : base(email, password, firstName, lastName, street, streetNumber, city, postalCode)
        {
        }

        public override void DisplayMembershipInfo()
        {
            MessageBox.Show("This is a Premium Membership");
        }
    }
}
