using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo.entidades
{
    public class Professor
    {
        private int id;
        private string nome;
        private string area;
        private DateTime dataAdmissao;
        private Turma[] turmas;

        public Professor(int id, string nome, string area, DateTime dataAdmissao)
        {
            this.id = id;
            this.nome = nome;
            this.area = area;
            this.dataAdmissao = dataAdmissao;
        }

        public Professor(int id, string nome, string area, DateTime dataAdmissao, Turma[] turmas)
        {
            this.id = id;
            this.nome = nome;
            this.area = area;
            this.dataAdmissao = dataAdmissao;
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

        private DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }

        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        public Turma[] Turmas
        {
            get { return turmas; }
            set { turmas = value; }
        }

        public override string ToString()
        {
            string turmasStr = turmas.Length > 0 ? string.Join(", ", turmas.Select(m => m.ToString())) : "Nenhum turma";
            return $"[ID: {id}; Nome: {Nome}; Área: {Area} ;Data Admissão: {DataAdmissao}; Turmas: [{turmasStr}]]";
        }
    }
}
