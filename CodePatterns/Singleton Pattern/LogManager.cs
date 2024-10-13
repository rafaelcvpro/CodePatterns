using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace CodePatterns.Singleton_Pattern
{
    public class LogManager
    {
        
        private static LogManager instance = new LogManager();
        public static LogManager Instance
        {
            get
            {
                if (instance == null)
                {
                    return instance = new LogManager();
                }
                return instance;
            }
           
        }

        // constructor as private 
        // create only one instace 
        // Keeps a lock on the file
        private LogManager()
        {
            _fileStream = File.OpenWrite(GetExecustionFolder() + "\\Application.log");
        }

        private FileStream _fileStream; 
        private StreamWriter? _streamWriter;       

        public void WriteLog(string message)
        {
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine("Date:" + DateTime.Now.ToString());
            formattedMessage.AppendLine("Message:" + message); 

            _streamWriter?.WriteLine(formattedMessage.ToString());
            _streamWriter?.Flush(); 
        }

        public string GetExecustionFolder()
        {
            if (!string.IsNullOrEmpty(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)))
            {
                return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) ?? string.Empty; 
            }

            return string.Empty; 
        }


    }
}
