using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.controllers;
using TrabalhoAvaliativo.models;

namespace TrabalhoAvaliativo.views
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            Text = "Página Inicial - MyUniversity";
            IsMdiContainer = true;
        }

        private void OpenNewView(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void alunosToolStripMenuItem_click(Object sender, EventArgs e)
        {
            var model = new AlunoModel();
            var view = new AlunoView();
            var controller = new AlunoController(model, view);
            view.SetController(controller);
            OpenNewView(view);
        }

        private void professoresToolStripMenuItem_click(object sender, EventArgs e)
        {
            var model = new ProfessorModel();
            var view = new ProfessorView();
            var controller = new ProfessorController(model, view);
            view.SetController(controller);
            OpenNewView(view);
        }

        private void cursosToolStripMenuItem_click(object sender, EventArgs e)
        {
            var model = new CursoModel();
            var view = new CursoView();
            var controller = new CursoController(model, view);
            view.SetController(controller);
            OpenNewView(view);
        }

        private void turmasToolStripMenuItem_click(object sender, EventArgs e)
        {
            var turmaModel = new TurmaModel();
            var cursoModel = new CursoModel();
            var professorModel = new ProfessorModel();
            var view = new TurmaView();
            var controller = new TurmaController(turmaModel, cursoModel, professorModel, view);
            view.SetController(controller);
            OpenNewView(view);
        }
    }
}
