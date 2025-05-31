using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.patterns.command.delete
{
    public class AlunoDeleteCommand : ICommand
    {
        private DataRepository _repository;
        private Aluno _aluno;
        private List<Matricula> _deleteData;

        public AlunoDeleteCommand(DataRepository repository, Aluno aluno)
        {
            _repository = repository;
            _aluno = aluno;
            _deleteData = new List<Matricula>();
        }

        public void Execute()
        {
            var matriculas = _repository.Matriculas.Where(m => m.Aluno.Id == _aluno.Id).ToList();

            if (matriculas.Any())
            {
                throw new Exception("Não é possível excluir o aluno, pois ele está matriculado em uma ou mais turmas!");
            }

            _deleteData.AddRange(matriculas);
            _repository.Matriculas.RemoveAll(m => m.Aluno.Id == _aluno.Id);
            _repository.Alunos.Remove(_aluno);
        }

        public void Undo()
        {
            _repository.Alunos.Add(_aluno);
            _repository.Matriculas.AddRange(_deleteData);
        }
    }
}
