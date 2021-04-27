using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        //tek parametreli olan methoda bu success işini ver.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //Succese set itme işini bu methoda veriyorum.
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
