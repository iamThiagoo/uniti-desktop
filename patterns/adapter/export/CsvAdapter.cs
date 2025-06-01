using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo.patterns.adapter.export
{
    public class CsvAdapter
    {
        public void Export(string content)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string filename = $"matriculas_cursos_{timestamp}.csv";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            File.WriteAllText(path, content);
        }
    }
}
