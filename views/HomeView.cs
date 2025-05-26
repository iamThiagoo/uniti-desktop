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

        private void alunosToolStripMenuItem_click(Object sender, EventArgs e)
        {
            AlunoModel model = new AlunoModel();
            AlunoView view = new AlunoView
            {
                MdiParent = this,
            };

            AlunoController controller = new AlunoController(model, view);
            view.SetController(controller);
            view.Show();
        }

        private void professoresToolStripMenuItem_click(object sender, EventArgs e)
        {
            ProfessorModel model = new ProfessorModel();
            ProfessorView view = new ProfessorView
            {
                MdiParent = this,
            };

            ProfessorController controller = new ProfessorController(model, view);
            view.SetController(controller);
            view.Show();
        }

        private void cursosToolStripMenuItem_click(object sender, EventArgs e)
        {
            CursoModel model = new CursoModel();
            CursoView view = new CursoView
            {
                MdiParent = this,
            };

            CursoController controller = new CursoController(model, view);
            view.SetController(controller);
            view.Show();
        }
    }
}
