using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.patterns.adapter;

namespace TrabalhoAvaliativo.patterns.template
{
    public class MatriculaReport : Report
    {
        private List<Matricula> _matriculas;

        public MatriculaReport(IAdapter adapter, List<Matricula> matriculas) : base(adapter)
        {
            _matriculas = matriculas;
        }

        protected override string FetchData()
        {
            return string.Empty;
        }

        protected override string BuildContent(string data)
        {
            var sb = new StringBuilder();
            sb.AppendLine("ID,Aluno,Turma");
            foreach (var m in _matriculas)
            {
                sb.AppendLine($"{m.Id},{m.Aluno.Nome},{m.Turma.Title}");
            }
            return sb.ToString();
        }
    }
}
