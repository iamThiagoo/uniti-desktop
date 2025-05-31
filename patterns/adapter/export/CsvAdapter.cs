using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo.patterns.adapter
{
    public class CsvAdapter : IAdapter
    {
        public void Export(string content)
        {
            string exportsDir = "exports";
            if (!Directory.Exists(exportsDir))
            {
                Directory.CreateDirectory(exportsDir);
            }

            string fileName = Path.Combine(exportsDir, $"matriculas_{DateTime.Now:yyyyMMdd_HHmmss}.csv");
            string csv = ConvertToCsvFormat(content);
            File.WriteAllText(fileName, csv, Encoding.UTF8);
        }

        private string ConvertToCsvFormat(string content)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Campo,Valor");
            builder.AppendLine($"Data de Geração,{DateTime.Now:dd/MM/yyyy HH:mm:ss}");

            var lines = content.Split('\n');
            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string escapedLine = line.Replace("\"", "\"\"");
                    if (escapedLine.Contains(",")) {
                        escapedLine = $"\"{escapedLine}\"";
                    }
                    builder.AppendLine($"Conteúdo,{escapedLine}");
                }
            }

            return builder.ToString();
        }
    }
}
