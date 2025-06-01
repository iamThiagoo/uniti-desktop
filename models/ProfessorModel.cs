using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.models
{
    public class ProfessorModel
    {
        private DataRepository repository;

        public ProfessorModel()
        {
            repository = DataRepository.Instance;
        }

        public void Insert(string nome, string area)
        {
            Professor newProfessor = new Professor(GetNextId(), nome, area);
            repository.Professores.Add(newProfessor);
        }

        public List<Professor> Find()
        {
            return repository.Professores.ToList();
        }

        public void Delete(int id)
        {
            Professor professor = repository.Professores.FirstOrDefault(a => a.Id == id);
            if (professor != null)
            {
                repository.Professores.Remove(professor);
            }
        }

        public int GetNextId()
        {
            if (!repository.Professores.Any())
                return 1;

            return repository.Professores.Max(a => a.Id) + 1;
        }
    }
}
