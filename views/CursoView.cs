using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.controllers;
using TrabalhoAvaliativo.entidades;

namespace TrabalhoAvaliativo.views
{
    public partial class CursoView : Form
    {
        private CursoController _controller;

        public CursoView()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public void SetController(CursoController controller)
        {
            _controller = controller;
        }

        public string NomeBox
        {
            get { return nomeCursoText.Text; }
            set { nomeCursoText.Text = value; }
        }

        public string DescricaoBox
        {
            get { return descricaoCursoText.Text; }
            set { descricaoCursoText.Text = value; }
        }

        public DataGridView CursoGridView
        {
            get { return cursosGridView; }
            set { cursosGridView = value; }
        }

        private void criaProfessorButton_click(object sender, EventArgs e)
        {
            _controller.Insert();
        }

        public void resetFields()
        {
            NomeBox = "";
            DescricaoBox = "";
        }

        public void UpdateDataGrid(List<Curso> cursos)
        {
            CursoGridView.Rows.Clear();

            foreach (var curso in cursos)
            {
                cursosGridView.Rows.Add(
                    curso.Id,
                    curso.Nome,
                    curso.Descricao
                );
            }
        }
    }
}
