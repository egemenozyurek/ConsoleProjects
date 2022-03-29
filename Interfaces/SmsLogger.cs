using System;

namespace Interfaces {
    public class SmsLogger : ILogger {
        public void WriteLog () {
            //throw new NotImplementException();
            Console.WriteLine ("Sms olarak log yaz.");
        }
    }

}