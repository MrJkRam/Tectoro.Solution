using Microsoft.AspNetCore.Mvc.Filters;
using QuantDeveloper.ExceptionLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantDeveloper.Api
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        private IExceptionLog _iExceptionLog;

        public CustomExceptionFilter()
        {

            _iExceptionLog = ExceptionLog.ExceptionLog.GetInstance;
        }
        public override void OnException(ExceptionContext exceptionContext)
        {
            _iExceptionLog.LogException(exceptionContext.Exception.ToString());
            exceptionContext.ExceptionHandled = true;
            //this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}
