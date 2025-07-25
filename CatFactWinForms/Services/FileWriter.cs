using CatFactWinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWinForms.Services
{
    public class FileWriter : IFileWriter
    {
        private readonly string _filePath;
        public FileWriter(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }

        public void AppendLine(string content)
        {
            File.AppendAllText(_filePath, content + Environment.NewLine);
        }

    }
}
