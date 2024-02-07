using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Classes
{
    public class MedicalCondition
    {
        public string Name { get; set; }
        public ConditionType? Type;
        public string Remarks { get; set; }

        public MedicalCondition(string name, ConditionType type, string remarks)
        {
            this.Name = name;
            this.Type = type;
            this.Remarks = remarks;
        }

        public override string ToString()
        {
            return "Condition: " + this.Name + "\tCondition Type: " + this.Type + "\tRemarks: " + this.Remarks;
        }
    }
}
