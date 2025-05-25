using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.entidades;

namespace TrabalhoAvaliativo.models.repository
{
    public class DataRepository
    {
        private static DataRepository _instance;
        private static readonly object _locker = new object();

        private List<Aluno> alunos;
        private List<Professor> professores;
        private List<Curso> cursos;
        private List<Turma> turmas;
        private List<Matricula> matriculas;

        private DataRepository() {
            alunos = new List<Aluno>();
            professores = new List<Professor>();
            cursos = new List<Curso>();
            turmas = new List<Turma>();
            matriculas = new List<Matricula>();
        }

        public List<Aluno> Alunos { 
            get { return alunos; }
            private set { alunos = value; }
        }

        public List<Professor> Professores
        {
            get { return professores; }
            private set { professores = value; }
        }

        public List<Curso> Cursos
        {
            get { return cursos; }
            private set { cursos = value; }
        }

        public List<Turma> Turmas
        {
            get { return turmas; }
            private set { turmas = value; }
        }

        public List<Matricula> Matriculas
        {
            get { return matriculas; }
            private set { matriculas = value; }
        }

        public static DataRepository Instance
        {
            get { return _instance; }
        }
    }
}
