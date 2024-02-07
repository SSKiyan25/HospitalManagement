using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        
        public Person(string name, string address, string contactNumber, string email)
        {
            this.Name = name;
            this.Address = address;
            this.ContactNumber = contactNumber;
            this.Email = email;
        }
    }
}
