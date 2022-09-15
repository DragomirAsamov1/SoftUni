using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts {
    public enum State {
        inProgress,
        Finished
    }
    public interface IMission {
        string CodeName { get; }
        State State { get; }

        void CompleteMission();
    }
}
