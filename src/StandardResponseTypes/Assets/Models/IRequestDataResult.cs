using System;
using System.Collections.Generic;
using System.Text;

namespace StandardResponseTypes.Assets.Models
{
    public interface IRequestDataResult<out T> : IRequestResult
    {
        T Data { get; }
    }
}
