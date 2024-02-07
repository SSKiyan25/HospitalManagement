using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public class Patient : Person
    {
        public int PatientID { get; set; }
        public List<MedicalCondition> medicalConditions;
        public List<Prescription> prescriptions;

        public Patient(string name, string address, string contactNumber, string email) : base(name, address, contactNumber, email)
        {
            this.medicalConditions = new List<MedicalCondition>();
            this.prescriptions = new List<Prescription>();
            this.PatientID++;
        }
        
        public override string ToString()
        {
            string disp = " ";
            disp += "Name: " + this.Name + "\n";
            disp += "Medical Conditions: \n";
            foreach (MedicalCondition mc in medicalConditions)
            {
                disp += mc.ToString() + "\n";
            }
            disp += "\nPrescriptions: \n";
            foreach (Prescription p in prescriptions)
            {
                disp += p.ToString() + "\n";
            }
            return disp;
        }
    }
}
