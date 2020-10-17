using System;
using System.Collections.Generic;
using System.Text;

namespace RuneSolverUI
{
    using System.IO;
    using System.Reflection;


    public class LogWriter
    {
        private string m_exePath = string.Empty;
        public LogWriter()
        {
        }
        public void LogWrite(string logMessage)
        {
            m_exePath = Directory.GetCurrentDirectory();
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.WriteLine($"{DateTime.Now.ToShortTimeString()} {DateTime.Now.ToShortDateString()} : {logMessage}");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
