using System;

namespace Interfaces {
    class Program {
        static void Main (string[] args) {
            FileLogger fileLogger = new FileLogger ();
            fileLogger.WriteLog ();

            SmsLogger smsLogger = new SmsLogger ();
            smsLogger.WriteLog ();

            DatabaseLogger databaseLogger = new DatabaseLogger ();
            databaseLogger.WriteLog ();

            LogManager logManager = new LogManager (new FileLogger ());
            logManager.WriteLog ();
        }
    }
}