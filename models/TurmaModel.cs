using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.models
{
    public class TurmaModel
    {
        private DataRepository repository;

        public TurmaModel()
        {
            repository = DataRepository.Instance;
        }

        public void Insert(Curso curso, Professor professor, int capacidade)
        {
            Turma newTurma = new Turma(GetNextId(), curso, professor, capacidade);
            repository.Turmas.Add(newTurma);
        }

        public List<Turma> Find()
        {
            return repository.Turmas.ToList();
        }

        public void Delete(int id)
        {
            Turma turma = repository.Turmas.FirstOrDefault(a => a.Id == id);
            if (turma != null)
            {
                repository.Turmas.Remove(turma);
            }
        }

        public int GetNextId()
        {
            if (!repository.Turmas.Any())
                return 1;

            return repository.Turmas.Max(a => a.Id) + 1;
        }

        public List<Turma> SearchByCurso(int cursoId)
        {
            return repository.Turmas.Where(t => t.Curso.Id == cursoId).ToList();
        }
    }
}
