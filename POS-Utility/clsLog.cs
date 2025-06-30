using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using POS_Utility;

namespace POS_Utility
{
    public static class clsLog
    {
        private static Logger Log { get; set; }
        static clsLog()
        {
            Log = LogManager.GetCurrentClassLogger();

            DateTime dateTime = DateTime.UtcNow.Date;
            var strDate = dateTime.ToString("ddMMyyyy");

            string fileName = String.Format("{0}{1}.txt", "log", strDate);

            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "F:\\POSLOG\\"+ fileName };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");


            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            NLog.LogManager.Configuration = config;
        }
        public static void Info(object msg)
        {
            Log.Info(msg);
        }
        public static void Error(object msg)
        {
            Log.Error(msg);
        }
    }
}
