using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.patterns.command.delete
{
    public class TurmaDeleteCommand : ICommand
    {
        private DataRepository _repository;
        private Turma _turma;
        private List<Matricula> _deletedData;

        public TurmaDeleteCommand(DataRepository repository, Turma turma)
        {
            _repository = repository;
            _turma = turma;
            _deletedData = new List<Matricula>();
        }

        public void Execute()
        {
            var matriculas = _repository.Matriculas.Where(m => m.Turma.Id == _turma.Id).ToList();

            if (matriculas.Any())
            {
                throw new Exception("Não é possível excluir a turma, pois ela possui alunos matriculados!");
            }

            _deletedData.AddRange(matriculas);
            _repository.Matriculas.RemoveAll(m => m.Turma.Id == _turma.Id);
            _repository.Turmas.Remove(_turma);
        }

        public void Undo()
        {
            _repository.Turmas.Add(_turma);
            _repository.Matriculas.AddRange(_deletedData);
        }
    }
}
