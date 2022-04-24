using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance {
    public class Customer 
    { // "public" makes the Method availble to other classes.
        //creating the Constructor - same 
        public Customer()
        {
        }

        public Customer(string firstName, string lastName, string eMail) =>
            (this.FirstName, this.LastName, this.Email) = (firstName, lastName, eMail);

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string GetDisplayText() => FirstName + " " + LastName + ", " + Email;
        // Thi "GetDisplayText" Method returns a string that concatenates the code

    }
}
