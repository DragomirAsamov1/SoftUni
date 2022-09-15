using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models {
    public class Engineer : SpecializedSoldier, IEngineer {
        private List<IRepair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps) {
            repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => this.repairs; 
        public void AddRepair(IRepair repair) {
            repairs.Add(repair);
        }
        public override string ToString() {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var repair in repairs) {
                sb.AppendLine("  " + repair.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
