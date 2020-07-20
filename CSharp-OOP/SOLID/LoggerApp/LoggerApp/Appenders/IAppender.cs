﻿using LoggerApp.Common;
using LoggerApp.Layouts;

namespace LoggerApp.Appenders
{
    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
