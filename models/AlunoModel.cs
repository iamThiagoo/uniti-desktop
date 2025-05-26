using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.models
{
    public class AlunoModel
    {
        private DataRepository repository;

        public AlunoModel()
        {
            repository = DataRepository.Instance;
        }

        public void Insert(string nome, string cpf, DateTime dataNascimento)
        {
            bool cpfExist = repository.Alunos.Exists(aluno => aluno.Cpf == cpf);

            if (cpfExist)
            {
                throw new Exception("CPF de Aluno já cadastrado!");
            }

            Aluno newAluno = new Aluno(GetNextId(), nome, cpf, dataNascimento);
            repository.Alunos.Add(newAluno);
        }

        public List<Aluno> Find()
        {
            return repository.Alunos.ToList();
        }

        public void Delete(int id)
        {
            Aluno aluno = repository.Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno != null)
            {
                repository.Alunos.Remove(aluno);
            }
        }

        public int GetNextId()
        {
            return repository.Alunos.Count + 1;
        }
    }
}
