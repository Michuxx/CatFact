using CatFactWinForms.Interfaces;
using System;
using System.IO;
using System.Windows.Forms;

namespace CatFactWinForms.Services
{
    public class FileWriter : IFileWriter
    {
        private readonly string _folderName;

        public FileWriter(string folderName)
        {
            _folderName = folderName;
        }

        public void AppendLine(string content, string filePath)
        {
            var path = Path.Combine(filePath, _folderName);
            try
            {
                File.AppendAllText(path, content + Environment.NewLine);
            }
            catch (Exception ex)
            {
             Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public string getValidatedPath(string path)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                return path;
            }
            else
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }
}
