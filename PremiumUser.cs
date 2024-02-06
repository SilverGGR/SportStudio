using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    public class PremiumUser : User
    {
        // Ein PremiumUser ist lediglich ein "Upgrade" und muss deswegen von einem normalen User entstehen und geupgradet werden
        public PremiumUser(User user) : base(user.Email, user.Password, user.FirstName, user.LastName, user.Street, user.StreetNumber, user.City, user.PostalCode)
        {
            this.UserMembership = user.UserMembership;
        }

        public override void DisplayMembershipInfo()
        {
            // Hier muss neue form hin
            new Secret().ShowDialog();
        }
    }
}
