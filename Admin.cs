using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    public class Admin : IUser
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }

        public Admin(string email, string password, string firstName) 
        {
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
        }

        public void ShowAttributes()
        {
            MessageBox.Show($"Du bist Admin: {FirstName}\nEmail: {Email}\nPassword: {Password}");
        }
    }
}
