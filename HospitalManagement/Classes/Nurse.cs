using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public class Nurse : Person
    {
        public string NurseID { get; set; }
        public string Department { get; set; }
        public string Shift { get; set; }

        public Nurse(string name, string address, string contactNumber, string email, string nurseID, string department, string shift, string qualification) : base(name, address, contactNumber, email)
        {
            this.NurseID = nurseID;
            this.Department = department;
            this.Shift = shift;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\tNurse ID: " + this.NurseID + "\tDepartment: " + this.Department + "\tShift: " + this.Shift;
        }
    }
}
