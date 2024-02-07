using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public class Hospital
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public List<Physician> Physicians;
        public List<Nurse> Nurses;
        public List<Room> Rooms;
        public List<Patient> Patients;

        public Hospital(string name, string address, string contactNumber, string email)
        {
            this.Name = name;
            this.Address = address;
            this.ContactNumber = contactNumber;
            this.Email = email;
            this.Physicians = new List<Physician>();
            this.Nurses = new List<Nurse>();
            this.Rooms = new List<Room>();
            this.Patients = new List<Patient>();
        }
        public void AddRoom(Room room)
        {
            this.Rooms.Add(room);
        }

        public void AddPhysician(Physician physician)
        {
            this.Physicians.Add(physician);
        }

        public void AddNurse(Nurse nurse)
        {
            this.Nurses.Add(nurse);
        }
        public void AddPatient(Patient patient)
        {
            this.Patients.Add(patient);
        }

        public override string ToString()
        {
            string disp = " ";
            disp += "Hospital Name: " + this.Name + "\n";
            disp += "Address: " + this.Address + "\n";
            disp += "Contact Number: " + this.ContactNumber + "\n";
            disp += "Email: " + this.Email + "\n";
            disp += "Physicians: \n";
            foreach (Physician p in Physicians)
            {
                disp += p.ToString() + "\n";
            }
            disp += "Nurses: \n";
            foreach (Nurse n in Nurses)
            {
                disp += n.ToString() + "\n";
            }
            disp += "Rooms: \n";
            foreach (Room r in Rooms)
            {
                disp += r.ToString() + "\n";
            }
            disp += "Patients: \n";
            foreach (Patient p in Patients)
            {
                disp += p.ToString() + "\n";
            }
            return disp;
        }
    }
}
