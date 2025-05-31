using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo.entidades
{
    public class Turma
    {
        private int id;
        private Curso curso;
        private Professor professor;
        private int capacidade;
        private Matricula[] matriculas;

        public Turma(int id, Curso curso, Professor professor, int capacidade)
        {
            this.id = id;
            this.curso = curso;
            this.professor = professor;
            this.capacidade = capacidade;
        }

        public Turma(int id, Curso curso, Professor professor, int capacidade, Matricula[] matriculas)
        {
            this.id = id;
            this.curso = curso;
            this.professor = professor;
            this.capacidade = capacidade;
            this.matriculas = matriculas;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public Professor Professor
        {
            get { return professor; }
            set { professor = value; }
        }

        public int Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        public Matricula[] Matriculas
        {
            get { return matriculas; }
            set { matriculas = value; }
        }

        public string Title
        {
            get { return $"{id} - {curso.Nome}"; }
        }

        public override string ToString()
        {
            string matriculasStr = matriculas != null && matriculas.Length > 0 ? string.Join(", ", matriculas.Select(m => m.ToString())) : "Nenhuma encontrada";
            return $"[ID: {id}, Curso: {curso.ToString()}, Professor: {professor?.Nome}, Capacidade: {capacidade}, Matrículas: [{matriculasStr}]]";
        }
    }
}
