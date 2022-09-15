using System;
using System.Collections.Generic;
using System.Text;

namespace P01._FileStream_Before {
    public interface IResult {
        int Length { get; }
        int Sent { get; }
    }
}
