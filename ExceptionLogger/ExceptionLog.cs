using System;
using System.IO;
using System.Text;

namespace ExceptionLogger
{
    //Singleton Design Pattern Implemented
    public sealed class ExceptionLog : iExceptionLog
    {

        private ExceptionLog()
        {
            //
        }

        private static readonly Lazy<ExceptionLog> instance = new Lazy<ExceptionLog>(()=>new ExceptionLog());

        public static ExceptionLog GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void LogException(string errormessage)
        {
            //throw new NotImplementedException();

            string fileName = string.Format("{0}_{1}.log", "Exception", "99");
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder strBldr = new StringBuilder();

            strBldr.AppendLine("------------------------------------------");
            strBldr.AppendLine(DateTime.Now.ToString());
            strBldr.AppendLine(errormessage);
            using (StreamWriter sw = new StreamWriter(logFilePath, true)) {
                sw.Write(strBldr.ToString());
                sw.Flush();
            }
        }
    }
}