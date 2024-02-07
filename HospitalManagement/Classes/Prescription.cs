using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public class Prescription
    {
        public Medicine Medicine;
        public int Grams { get; set; }
        public string Dosage { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Remarks { get; set; }

        public Prescription(Medicine med)
        {
            this.Medicine = new Medicine(med);
            this.Grams = 0;
            this.Dosage = string.Empty;
            this.StartDate = string.Empty;
            this.EndDate = string.Empty;
            this.Remarks = string.Empty;
        }

        public override string ToString()
        {
            string disp = "Prescription Details\n";
            disp += "Medicine: " + this.Medicine.Name + "\t Grams: " + this.Grams;
            disp += "\nDosage: " + this.Dosage + "\t Start Date: " + this.StartDate + "\t End Date:" + this.EndDate;
            return disp;
        }
    }
}
