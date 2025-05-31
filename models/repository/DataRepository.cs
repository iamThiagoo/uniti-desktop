using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            startData();
        }

        public void startData()
        {
            InsertAlunos();
            InsertProfessores();
            InsertCursos();
            InsertTurmas();
            InsertMatriculas();
        }

        public void InsertAlunos()
        {
            alunos.Add(new Aluno(1, "Thiago Ferreira", "642.061.100-85", DateTime.Parse("06/12/2003")));
            alunos.Add(new Aluno(2, "Eliane Raquel Dias", "410.089.037-01", DateTime.Parse("16/02/1993")));
            alunos.Add(new Aluno(3, "Isabela Rafaela Caldeira", "490.638.738-16", DateTime.Parse("18/04/1990")));
            alunos.Add(new Aluno(4, "Manoel Raul", "042.540.160-00", DateTime.Parse("01/04/1966")));
            alunos.Add(new Aluno(5, "Adriana Rafaela Peixoto", "549.697.396-17", DateTime.Parse("18/07/1999")));
            alunos.Add(new Aluno(6, "Lucas Gabriel da Silva", "321.654.987-00", DateTime.Parse("10/11/2001")));
            alunos.Add(new Aluno(7, "Maria Eduarda Lima", "789.456.123-88", DateTime.Parse("25/05/2002")));
            alunos.Add(new Aluno(8, "Rafael Augusto Borges", "258.369.147-22", DateTime.Parse("30/03/1995")));
            alunos.Add(new Aluno(9, "Fernanda Alves Rocha", "963.852.741-55", DateTime.Parse("09/09/1997")));
            alunos.Add(new Aluno(10, "Carlos Henrique Souza", "147.258.369-33", DateTime.Parse("12/12/1988")));
        }

        public void InsertProfessores()
        {
            professores.Add(new Professor(1, "André Luiz Costa", "Especialista na área de TI."));
            professores.Add(new Professor(2, "Carla Beatriz Moura", "Especialista na área de TI."));
            professores.Add(new Professor(3, "Fernando Henrique Lopes", "Especialista na área de TI."));
            professores.Add(new Professor(4, "Juliana Silva Rocha", "Especialista na área de TI."));
            professores.Add(new Professor(5, "Bruno César Almeida", "Especialista na área de TI."));
            professores.Add(new Professor(6, "Renata Oliveira Nunes", "Especialista na área de TI."));
            professores.Add(new Professor(7, "Eduardo Lima Soares", "Especialista na área de TI."));
            professores.Add(new Professor(8, "Patrícia Ramos Vieira", "Especialista na área de TI."));
            professores.Add(new Professor(9, "Luciano Martins Pinto", "Especialista na área de TI."));
            professores.Add(new Professor(10, "Débora Cristina Dias", "Especialista na área de TI."));
        }

        public void InsertCursos()
        {
            cursos.Add(new Curso(1, "Análise e Desenvolvimento de Sistemas", "Formação focada em desenvolvimento de softwares, bancos de dados e lógica de programação."));
            cursos.Add(new Curso(2, "Ciência da Computação", "Curso voltado à base teórica e prática da computação, com ênfase em algoritmos e estruturas de dados."));
            cursos.Add(new Curso(3, "Engenharia de Software", "Estudo e aplicação de técnicas para o desenvolvimento e manutenção de sistemas complexos."));
            cursos.Add(new Curso(4, "Redes de Computadores", "Curso que ensina a planejar, implantar e administrar redes locais e distribuídas."));
            cursos.Add(new Curso(5, "Sistemas de Informação", "Voltado para gestão da informação em empresas, com conhecimentos em TI e administração."));
            cursos.Add(new Curso(6, "Segurança da Informação", "Capacita profissionais para proteger dados e sistemas contra ameaças digitais."));
            cursos.Add(new Curso(7, "Banco de Dados", "Curso focado no gerenciamento, modelagem e segurança de grandes volumes de dados."));
            cursos.Add(new Curso(8, "Desenvolvimento Mobile", "Ensina a criação de aplicativos para plataformas como Android e iOS."));
            cursos.Add(new Curso(9, "Inteligência Artificial", "Estudo de algoritmos que simulam a inteligência humana para tomada de decisões."));
            cursos.Add(new Curso(10, "Computação em Nuvem", "Formação voltada à arquitetura, desenvolvimento e manutenção de soluções em cloud computing."));
        }

        public void InsertTurmas()
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Curso curso = cursos[random.Next(cursos.Count)];
                Professor professor = professores[random.Next(professores.Count)];
                turmas.Add(new Turma(turmas.Count + 1, curso, professor, 50));
            }
        }

        public void InsertMatriculas()
        {
            Random random = new Random();
            int i = 0;

            while (i < 15)
            {
                Aluno aluno = alunos[random.Next(alunos.Count)];
                Turma turma = turmas[random.Next(turmas.Count)];

                if (matriculas.Any(m => m.Aluno == aluno && m.Turma == turma))
                {
                    continue;
                }

                matriculas.Add(new Matricula(matriculas.Count + 1, aluno, turma));
                i++;
            }
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
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new DataRepository();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
