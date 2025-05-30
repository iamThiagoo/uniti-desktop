using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo.entidades
{
    public class Aluno
    {
        private int id;
        private string nome;
        private string cpf;
        private DateTime dataNascimento;
        private Matricula[] matriculas;

        public Aluno(int id, string nome, string cpf, DateTime dataNascimento)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
        }

        public Aluno(int id, string nome, string cpf, DateTime dataNascimento, Matricula[] matriculas)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.matriculas = matriculas;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public Matricula[] Matriculas
        {
            get { return matriculas; }
            set { matriculas = value; }
        }

        public override string ToString()
        {
            string matriculasStr = matriculas != null && matriculas.Length > 0 ? string.Join(", ", matriculas.Select(m => m.ToString())) : "Nenhuma encontrada";
            return $"[ID: {id}; Nome: {Nome}; Data Nascimento: {DataNascimento}; Matrículas: [{matriculasStr}]]";
        }
    }
}
