using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class FileLogger
    {
        private string filePath;

        public FileLogger(string path, MessagePublisher publisher)
        {
            filePath = path;
            publisher.SendMessage += TimeLog;
        }

        private void TimeLog(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] {message}");
            }
        }
    }
}
