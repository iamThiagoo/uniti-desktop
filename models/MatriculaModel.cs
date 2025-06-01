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
            bool alunoExist = repository.Matriculas.Exists(m => m.Aluno.Id == aluno.Id && m.Turma.Id == turma.Id);

            if (alunoExist)
            {
                throw new Exception("Aluno já cadastrado nessa turma!");
            }

            int matriculasCount = repository.Matriculas.Count(m => m.Turma.Id == turma.Id);

            if (matriculasCount >= turma.Capacidade)
            {
                throw new Exception("A turma atingiu sua capacidade máxima!");
            }

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
            if (!repository.Matriculas.Any())
                return 1;

            return repository.Matriculas.Max(a => a.Id) + 1;
        }

        public List<Matricula> SearchByTurma(int turmaId)
        {
            return repository.Matriculas.Where(t => t.Turma.Id == turmaId).ToList();
        }
    }
}
