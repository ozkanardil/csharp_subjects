using System;
using System.Collections.Generic;
using System.Text;

namespace StandardResponseTypes.Assets.Models
{
    public interface IRequestResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
