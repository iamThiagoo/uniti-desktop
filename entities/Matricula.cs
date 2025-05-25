using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo.entidades
{
    public class Matricula
    {
        private int id;
        private Aluno aluno;
        private Turma turma;
        private DateTime dataMatricula;

        public Matricula(int id, Aluno aluno, Turma turma, DateTime dataMatricula)
        {
            this.id = id;
            this.aluno = aluno;
            this.turma = turma;
            this.dataMatricula = dataMatricula;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public Turma Turma
        {
            get { return turma; }
            set { turma = value; }
        }

        public DateTime DataMatricula
        {
            get { return dataMatricula; }
            set { dataMatricula = value; }
        }

        public override string ToString()
        {
            return $"[ID: {id}, Aluno: {aluno.Nome}, Data da Matrícula: {dataMatricula:dd/MM/yyyy}; Turma: {turma.ToString()}]";
        }
    }
}
