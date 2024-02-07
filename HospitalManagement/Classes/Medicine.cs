using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public class Medicine
    {
        public string Name { get; set; }
        public string ExpiryDate { get; set; }


        public Medicine(string name, string expiryDate)
        {
            this.Name = name;
            this.ExpiryDate = expiryDate;
        }
        
        public Medicine(Medicine med)
        {
            this.Name = med.Name;
            this.ExpiryDate = med.ExpiryDate;
        }
        public override string ToString()
        {
            return "Medicine: " + this.Name + "\tExpiry Date: " + this.ExpiryDate;
        }
    }
}
