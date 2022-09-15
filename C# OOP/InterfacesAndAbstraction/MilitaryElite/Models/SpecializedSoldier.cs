using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models {
    public class SpecializedSoldier : Private, ISpecializedSoldier{
        public SpecializedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary) {
        }

        public Corps Corps { get; private set; }
        private void ParseCorps(string corpsStr) {
            Corps corps;
            if (Enum.TryParse(corpsStr, out corps)) {
                this.Corps = corps;
            }
        }

        public override string ToString() {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps.ToString()}";
        }
    }
}
