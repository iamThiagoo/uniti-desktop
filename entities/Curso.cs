using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo.entidades
{
    public class Curso
    {
        private int id;
        private string nome;
        private string descricao;
        private Turma[] turmas;

        public Curso(int id, string nome, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
        }

        public Curso(int id, string nome, string descricao, Turma[] turmas)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.turmas = turmas;
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

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Turma[] Turmas
        {
            get { return turmas; }
            set { turmas = value; }
        }

        public override string ToString()
        {
            string turmasStr = (turmas != null && turmas.Length > 0) ? string.Join(", ", turmas.Select(t => t.ToString())) : "Nenhuma turma encontrada";
            return $"[ID: {id}; Nome: {Nome}; Descrição: {Descricao}; Turmas: [{turmasStr}]]";
        }
    }
}
