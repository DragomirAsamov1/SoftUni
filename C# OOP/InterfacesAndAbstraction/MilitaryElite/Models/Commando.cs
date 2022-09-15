using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models {
    public class Commando : SpecializedSoldier, ICommando{
        private List<IMission> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps) {
            missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => this.missions;
        
        public void AddMission(IMission mission) {
            missions.Add(mission);
        }

        public override string ToString() {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            foreach (var mission in missions) {
                sb.AppendLine("  " + mission.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
