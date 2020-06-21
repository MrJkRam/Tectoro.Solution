using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionLogger
{
    public interface iExceptionLog
    {
        void LogException(string errormessage);
    }
}