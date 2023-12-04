using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    internal class Customer : Person
    {

        private bool student { get; set; }
        private Membership membership { get; set; }

        public Customer(int id, string firstName, string lastName, string dateOfBirth, Address address, bool student, Membership membership)
            : base(id, firstName, lastName, dateOfBirth, address)
        {
            this.student = student;
            this.membership = membership;
        }
    }
}
