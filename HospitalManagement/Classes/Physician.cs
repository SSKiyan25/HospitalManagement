using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public class Physician : Person
    {
        public string Specialization { get; set; }
        public string Department { get; set; }
        public string LicenseNum { get; set; }
        public List<Patient> Patients { get; set; }

        public Physician(string name, string address, string contactNumber, string email, string specialization, string department, string licensenum) : base(name, address, contactNumber, email)
        {
            this.Specialization = specialization;
            this.Department = department;
            this.LicenseNum = licensenum;
            this.Patients = new List<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void RemovePatient(Patient patient)
        {
            Patients.Remove(patient);
        }

        public void PrescribeMedication(Patient patient, Prescription prescription)
        {
            patient.prescriptions.Add(prescription);
        }

        public void AddMedicalCondition(Patient patient, MedicalCondition medicalCondition)
        {
            patient.medicalConditions.Add(medicalCondition);
        }

        public void RemoveMedicalCondition(Patient patient, MedicalCondition medicalCondition)
        {
            patient.medicalConditions.Remove(medicalCondition);
        }

        public void RemovePrescription(Patient patient, Prescription prescription)
        {
            patient.prescriptions.Remove(prescription);
        }

        public override string ToString()
        {
            string disp = " ";
            disp += "Name: " + this.Name + "\n";
            return Name;
        }
    }
}
