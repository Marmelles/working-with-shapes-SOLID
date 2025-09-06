using SOLID_pattern.Interfaces;

namespace SOLID_pattern.Services
{
    public class FileLogger : ILogger
    {
        private readonly string _logPath = "app.log.txt"; // будет в папке с .exe

        public void Log(string message)
        {
            string line = $"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            File.AppendAllText(_logPath, line + Environment.NewLine);
        }
    }
}
