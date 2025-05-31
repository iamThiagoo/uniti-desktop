using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models.repository;

namespace TrabalhoAvaliativo.patterns.command.delete
{
    public class CursoDeleteCommand : ICommand
    {
        private DataRepository _repository;
        private Curso _curso;
        private List<Turma> _deletedData;

        public CursoDeleteCommand(DataRepository repository, Curso curso)
        {
            _repository = repository;
            _curso = curso;
            _deletedData = new List<Turma>();
        }

        public void Execute()
        {
            var turmas = _repository.Turmas.Where(t => t.Curso.Id == _curso.Id).ToList();
            
            if (turmas.Any())
            {
                throw new Exception("Não é possível excluir o curso, pois ele possui turmas associadas!");
            }

            _deletedData.AddRange(turmas);
            _repository.Turmas.RemoveAll(t => t.Curso.Id == _curso.Id);
            _repository.Cursos.Remove(_curso);
        }

        public void Undo()
        {
            _repository.Cursos.Add(_curso);
            _repository.Turmas.AddRange(_deletedData);
        }
    }
}
