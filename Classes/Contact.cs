using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Classes {
    public class Contact {
        private string firstName;
        private string lastName;
        private short age;
        private string email;
            
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Age {
            get { return age.ToString(); }
            set { Int16.TryParse(value, out age); }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public Contact(string firstName, string lastName, string age, string email) {
            this.firstName = firstName;
            this.lastName = lastName;
            if (Int16.TryParse(age, out this.age)) {
                this.age = Int16.Parse(age);
            }
            this.email = email;
        }

    }
}
