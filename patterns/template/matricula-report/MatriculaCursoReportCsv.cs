using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;
using TrabalhoAvaliativo.patterns.adapter;
using TrabalhoAvaliativo.patterns.adapter.export;

namespace TrabalhoAvaliativo.patterns.template
{
    public class MatriculaCursoReportCsv : MatriculaTemplate
    {
        protected override string Build(List<Curso> cursos, List<Matricula> matriculas)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Curso,Descrição,Aluno,Turma");
            sb.AppendLine();

            foreach (var curso in cursos)
            {
                var matriculasCurso = matriculas.Where(m => m.Turma.Curso.Id == curso.Id).ToList();

                if (matriculasCurso.Count == 0)
                {
                    sb.AppendLine($"{curso.Nome},{curso.Descricao},Nenhuma matrícula encontrada,-");
                }
                else
                {
                    foreach (var matricula in matriculasCurso)
                    {
                        sb.AppendLine($"{curso.Nome},{curso.Descricao},{matricula.Aluno.Nome},{matricula.Turma.Title}");
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        protected override (List<Curso>, List<Matricula>) FetchData()
        {
            var cursos = DataRepository.Instance.Cursos;
            var matriculas = DataRepository.Instance.Matriculas;
            return (cursos, matriculas);
        }

        protected override void Export(string content)
        {
            new CsvAdapter().Export(content);
        }
    }
}
