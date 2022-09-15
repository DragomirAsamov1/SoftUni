using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProject {
    internal class Team {

        public Team(string name, string creatorName) {
            this.TeamName = name;
            this.CreatorName = creatorName;
            Members = new List<string>();
        }

        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}
