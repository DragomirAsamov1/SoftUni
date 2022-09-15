using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts {
    public interface IEngineer : ISpecializedSoldier {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
