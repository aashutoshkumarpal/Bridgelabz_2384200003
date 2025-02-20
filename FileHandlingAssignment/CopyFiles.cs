using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingAssignment
{
    internal class CopyFiles
    {
        public void CopyFilesHandler(string SourceFile, string DestinationFile)
        {
            try
            {
                if (!File.Exists(SourceFile))
                {
                    Console.WriteLine("File not found");
                    return;
                }

                using (FileStream fts = new FileStream(SourceFile, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fts)) { 
                    
                    string content = sr.ReadToEnd();

                    using (FileStream fwriter = new FileStream(DestinationFile, FileMode.Create, FileAccess.Write))
                    using (StreamWriter writer = new StreamWriter(fwriter))
                    {
                        writer.Write(content);
                    }

                    Console.WriteLine("File copied successfully!");        
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while handling the file: " + ex.Message);
            }
        }
        public void InputMethod()
        {
            string SourceFile = Console.ReadLine();
            string DestinationFile = Console.ReadLine();

            CopyFilesHandler(SourceFile, DestinationFile);
        }
    }
}
