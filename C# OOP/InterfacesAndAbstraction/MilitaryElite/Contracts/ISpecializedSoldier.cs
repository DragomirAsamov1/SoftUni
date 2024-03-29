﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts {
    public enum Corps {
        Airforces,
        Marines
    }
    public interface ISpecializedSoldier : IPrivate {
        Corps Corps { get; }
    }
}
