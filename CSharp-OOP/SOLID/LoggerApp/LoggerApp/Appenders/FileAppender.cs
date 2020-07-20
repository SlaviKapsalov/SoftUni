﻿using System;
using LoggerApp.Common;
using LoggerApp.Layouts;

namespace LoggerApp.Appenders
{
    public class FileAppender : Appender
    {
        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile) : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string res = string.Format(this.Layout.Template, dateTime, reportLevel, message) + Environment.NewLine;
                this.logFile.Write(res);
            }
        }
    }
}
