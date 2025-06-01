using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;

namespace TrabalhoAvaliativo.patterns.template
{
    public abstract class MatriculaTemplate
    {
        public void Generate()
        {
            var (cursos, matriculas) = FetchData();
            var conteudo = Build(cursos, matriculas);
            Export(conteudo);
        }

        protected abstract (List<Curso>, List<Matricula>) FetchData();
        protected abstract string Build(List<Curso> cursos, List<Matricula> matriculas);
        protected abstract void Export(string conteudo);
    }
}
