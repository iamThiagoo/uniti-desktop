using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo.patterns.adapter
{
    public class TxtAdapter : IAdapter
    {
        public void Export(string content)
        {
            try
            {
                string fullExportsPath = Path.Combine(Directory.GetCurrentDirectory(), "exports");
                Directory.CreateDirectory(fullExportsPath);
                Debug.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "exports"));
                string fileName = Path.Combine(fullExportsPath, $"matriculas_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
                Debug.WriteLine(fileName);
                string formattedContent = FormatContent(content);
                File.WriteAllText(fileName, formattedContent, Encoding.UTF8);
            }
            catch (IOException ex)
            {
                throw new Exception("Failed to export content to text file.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception("Access denied while creating or writing to the file.", ex);
            }
        }

        private string FormatContent(string content)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Matrículas por Turmas");
            builder.AppendLine($"Data: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            builder.AppendLine(new string('-', 30));
            builder.AppendLine(content.Trim());
            builder.AppendLine(new string('-', 30));
            return builder.ToString();
        }
    }
}
