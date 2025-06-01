using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;
using TrabalhoAvaliativo.patterns.adapter;

namespace TrabalhoAvaliativo.patterns.template
{
    public class MatriculaCursoReportTxt : MatriculaTemplate
    {
        protected override string Build(List<Curso> cursos, List<Matricula> matriculas)
        {
            var sb = new StringBuilder();
            sb.AppendLine("MATRÍCULAS POR CURSO");
            sb.AppendLine();

            foreach (var curso in cursos)
            {
                sb.AppendLine(new string('-', 40));
                sb.AppendLine($"Curso: {curso.Nome}");
                sb.AppendLine($"Descrição: {curso.Descricao}");
                sb.AppendLine();
                sb.AppendLine("Matrículas:");

                var matriculasCurso = matriculas.Where(m => m.Turma.Curso.Id == curso.Id).ToList();

                if (matriculasCurso.Count == 0)
                {
                    sb.AppendLine("Nenhuma matrícula encontrada.");
                }
                else
                {
                    foreach (var matricula in matriculasCurso)
                    {
                        sb.AppendLine($"Aluno: {matricula.Aluno.Nome} | Turma: {matricula.Turma.Title}");
                    }
                }
                sb.AppendLine(new string('-', 40));
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

        protected override void Export(string conteudo)
        {
            new TxtAdapter().Export(conteudo);
        }
    }
}
