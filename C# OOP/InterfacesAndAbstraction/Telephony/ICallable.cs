using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony {
    public interface ICallable {
        string Call(string number);
    }
}
