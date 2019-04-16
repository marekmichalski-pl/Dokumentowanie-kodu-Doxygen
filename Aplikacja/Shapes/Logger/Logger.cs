using System;
using System.IO;
using System.Text;

namespace Shapes
{
    /// <summary>
    /// Error logger.
    /// </summary>
    static class Logger
    {
        const string LOG_FILE = "log.txt";

        /// <summary>
        /// Get actual date nd time and build time stamp for logger
        /// </summary>
        /// <returns></returns>
        private static string GetTimeStamp()
        {
            DateTime data = DateTime.UtcNow.ToLocalTime();
            return data.ToString("dd-MM-yyyy hh:mm:ss");
        }

        /// <summary>
        /// Append logger text to file.
        /// </summary>
        /// <returns></returns>
        private static void WriteToFile(string s)
        {
            File.AppendAllText(LOG_FILE, s + Environment.NewLine);
        }

        /// <summary>
        /// Bulid error message to write to file. 
        /// </summary>
        /// <returns></returns>
        public static void Error(string s)
        {
            string error = GetTimeStamp() + '|' + "ERROR" + '|' + s;

            WriteToFile(error);
        }


    }
}