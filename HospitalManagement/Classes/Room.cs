using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public RoomType Type;

        private List<Nurse> nurses;
        private List<Patient> patients;

        public Room(RoomType type, int capacity)
        {
            this.RoomNumber++;
            this.Type = type;
            this.Capacity = capacity;
            this.patients = new List<Patient>();
            this.nurses = new List<Nurse>();
        }

        public void AddPatient(Patient patient)
        {
            if (this.patients.Count < this.Capacity)
                this.patients.Add(patient);
            else
                throw new Exception("Room is full");
        }
        public void RemovePatient(Patient patient)
        {
            this.patients.Remove(patient);
        }

        public void AddNurse(Nurse nurse)
        {
            this.nurses.Add(nurse);
        }
        public void RemoveNurse(Nurse nurse)
        {
            this.nurses.Remove(nurse);
        }

        public override string ToString()
        {
            string disp = " ";
            disp += "Room Number: " + this.RoomNumber + "\n";
            disp += "Room Type: " + this.Type + "\n";
            disp += "Capacity: " + this.Capacity + "\n";
            disp += "Patients: \n";
            foreach (Patient p in patients)
            {
                disp += p.ToString() + "\n";
            }
            disp += "Nurses: \n";
            foreach (Nurse n in nurses)
            {
                disp += n.ToString() + "\n";
            }
            return disp;
        }
    }
}
