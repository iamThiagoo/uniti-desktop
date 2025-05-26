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
    public partial class ProfessorView : Form
    {
        private ProfessorController _controller;

        public ProfessorView()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public void SetController(ProfessorController controller)
        {
            _controller = controller;
        }

        public string NomeBox
        {
            get { return nomeProfessorText.Text; }
            set { nomeProfessorText.Text = value; }
        }

        public string AreaBox
        {
            get { return areaProfessorText.Text; }
            set { areaProfessorText.Text = value; }
        }

        public DataGridView ProfessorGridView
        {
            get { return professorGridView; }
            set { professorGridView = value; }
        }

        private void criaProfessorButton_click(object sender, EventArgs e)
        {
            _controller.Insert();
        }

        public void resetFields()
        {
            NomeBox = "";
            AreaBox = "";
        }

        public void UpdateDataGrid(List<Professor> professores)
        {
            ProfessorGridView.Rows.Clear();

            foreach (var professor in professores)
            {
                ProfessorGridView.Rows.Add(
                    professor.Id,
                    professor.Nome,
                    professor.Area
                );
            }
        }
    }
}
