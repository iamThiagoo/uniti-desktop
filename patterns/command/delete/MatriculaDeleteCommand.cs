using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.patterns.command.delete
{
    public class MatriculaDeleteCommand
    {
        private readonly DataRepository _repository;
        private readonly Matricula _matricula;
        private bool _executed;

        public MatriculaDeleteCommand(DataRepository repository, Matricula matricula)
        {
            _repository = repository;
            _matricula = matricula;
            _executed = false;
        }

        public void Execute()
        {
            _repository.Matriculas.Remove(_matricula);
            _executed = true;
        }

        public void Undo()
        {
            if (_executed) {
                _repository.Matriculas.Add(_matricula);
                _executed = false;
            }
        }
    }
}
