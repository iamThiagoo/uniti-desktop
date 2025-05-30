using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.models
{
    public class MatriculaModel
    {
        private DataRepository repository;

        public MatriculaModel()
        {
            repository = DataRepository.Instance;
        }

        public void Insert(Aluno aluno, Turma turma)
        {
            Matricula newMatricula = new Matricula(GetNextId(), aluno, turma);
            repository.Matriculas.Add(newMatricula);
        }

        public List<Matricula> Find()
        {
            return repository.Matriculas.ToList();
        }

        public void Delete(int id)
        {
            Matricula matricula = repository.Matriculas.FirstOrDefault(a => a.Id == id);
            if (matricula != null)
            {
                repository.Matriculas.Remove(matricula);
            }
        }

        public int GetNextId()
        {
            return repository.Matriculas.Count + 1;
        }
    }
}
