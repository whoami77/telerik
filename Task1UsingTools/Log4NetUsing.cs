namespace Task1UsingTools
{
    using System;

    using log4net;
    using log4net.Appender;
    using log4net.Config;
    using log4net.Core;
    using log4net.Layout;

    public class Log4NetUsing
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetUsing));

        public static void Main()
        {
            FileAppender fileAppender = new FileAppender();
            fileAppender.File = @"..\..\log.txt";
            fileAppender.AppendToFile = true;
            fileAppender.Layout = new SimpleLayout();
            fileAppender.Threshold = Level.Debug;
            fileAppender.ActivateOptions();

            BasicConfigurator.Configure(fileAppender);
            Log.Debug("Debug msg");
            Log.Error("Error msg");
            Log.Warn("Warnning msg");

            try
            {
                int[] numbers = { 1, 2 };

                int number = numbers[10];
            }
            catch (IndexOutOfRangeException ex)
            {
                Log.Fatal(ex);
            }
        }
    }
}
