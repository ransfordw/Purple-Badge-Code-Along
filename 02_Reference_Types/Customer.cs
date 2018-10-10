using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reference_Types
{
    public class Customer
    {
        //-- Properties
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string nameFirst, string nameLast, string email, string number)
        {
            FirstName = nameFirst;
            LastName = nameLast;
            Email = email;
            PhoneNumber = number;
        }
        public Customer() {}

        //-- "Ransford","Walker", "ransfordw@gmail.com", "317-535-0324"
    }
}
