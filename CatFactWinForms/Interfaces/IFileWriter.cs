using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWinForms.Interfaces
{
    public interface IFileWriter
    {
        void AppendLine(string content, string filePath);
    }
}
