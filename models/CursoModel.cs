using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.models
{
    public class CursoModel
    {
        private DataRepository repository;

        public CursoModel()
        {
            repository = DataRepository.Instance;
        }

        public void Insert(string nome, string descricao)
        {
            Curso newCurso = new Curso(GetNextId(), nome, descricao);
            repository.Cursos.Add(newCurso);
        }

        public List<Curso> Find()
        {
            return repository.Cursos.ToList();
        }

        public void Delete(int id)
        {
            Curso curso = repository.Cursos.FirstOrDefault(a => a.Id == id);
            if (curso != null)
            {
                repository.Cursos.Remove(curso);
            }
        }

        public int GetNextId()
        {
            if (!repository.Cursos.Any())
                return 1;

            return repository.Cursos.Max(a => a.Id) + 1;
        }
    }
}
