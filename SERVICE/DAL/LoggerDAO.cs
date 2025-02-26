using SERVICE.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL
{
    internal static class LoggerDao
    {
        public static string PathLogError { get; set; } = ConfigurationManager.AppSettings["PathLogError"];
        public static string PathLogInfo { get; set; } = ConfigurationManager.AppSettings["PathLogInfo"];

        public static void WriteLog(Log log, Exception ex = null)
        {
            try
            {
                string message = FormatMessage(log);

                if (ex != null)
                {
                    message += $"\nExcepción: {ex.Message}";
                    message += $"\nInnerException: {ex.InnerException?.Message ?? "N/A"}";
                    message += $"\nStackTrace: {ex.StackTrace}";
                }

                switch (log.Level)
                {
                    case TraceLevel.Error:
                        WriteLogToFile(PathLogError, message);
                        break;

                    case TraceLevel.Warning:
                        WriteLogToFile(PathLogError, message);
                        break;

                    case TraceLevel.Info:
                        WriteLogToFile(PathLogInfo, message);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException($"Nivel de log no soportado: {log.Level}");
                }
            }
            catch (Exception loggerException)
            {
                Console.WriteLine($"Error en el LoggerDao: {loggerException.Message}");
            }
        }

        private static string FormatMessage(Log log)
        {
            return $"[{log.Date:yyyy-MM-dd HH:mm:ss}] {log.Level}: {log.Message}";
        }

        private static void WriteLogToFile(string fileName, string message)
        {
            try
            {
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fullPath = Path.Combine(folderPath, $"{DateTime.Now:yyyy-MM-dd}-{fileName}");

                using (StreamWriter writer = new StreamWriter(fullPath, true))
                {
                    writer.WriteLine(message);
                    writer.WriteLine(new string('-', 80));
                }
            }
            catch (Exception fileException)
            {
                Console.WriteLine($"Error al escribir el log en el archivo: {fileException.Message}");
            }
        }
    }
}
