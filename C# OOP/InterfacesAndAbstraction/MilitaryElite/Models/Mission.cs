using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models {
    public class Mission : IMission {
        public Mission(string codeName, string state) {
            CodeName = codeName;
            ParseState(state);
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission() {
            if (this.State == State.Finished) {
                throw new InvalidOperationException("Mission already finished!");
            }
            this.State = State.Finished;
        }

        private void ParseState(string stateStr) {
            State state;
            if(Enum.TryParse(stateStr, out state)) {
                this.State = state;
            }
        }

        public override string ToString() => $"Code Name: {CodeName} State {State.ToString()}";
    }
}
