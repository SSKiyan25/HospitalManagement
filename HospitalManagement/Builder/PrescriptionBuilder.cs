using HospitalManagement.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Classes;

namespace HospitalManagement.Builder
{
    public class PrescriptionBuilder
    {
        private Prescription prescription;

        public PrescriptionBuilder()
        {
            this.prescription = new Prescription();
        }

        public PrescriptionBuilder Medicine(Medicine medicine)
        {
            this.prescription.Medicine = medicine;
            return this;
        }
        public PrescriptionBuilder Grams(int grams)
        {
            this.prescription.Grams = grams;
            return this;
        }
        public PrescriptionBuilder Dosage(string dosage)
        {
            this.prescription.Dosage = dosage;
            return this;
        }
        public PrescriptionBuilder StartDate(string startDate)
        {
            this.prescription.StartDate = startDate;
            return this;
        }
        public PrescriptionBuilder EndDate(string endDate)
        {
            this.prescription.EndDate = endDate;
            return this;
        }
        public PrescriptionBuilder Remarks(string remarks)
        {
            this.prescription.Remarks = remarks;
            return this;
        }
        public Prescription Build()
        {
            return this.prescription;
        }
    }
}
