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
    public partial class TurmaView : Form
    {
        private TurmaController _controller;

        public TurmaView()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public void SetController(TurmaController controller)
        {
            _controller = controller;
        }

        public ComboBox CursoCombo
        {
            get { return cursoComboBox; }
            set { cursoComboBox = value; }
        }

        public Curso CursoComboBox
        {
            get { return (Curso)cursoComboBox.SelectedItem; }
            set { cursoComboBox.SelectedItem = value; }
        }

        public ComboBox ProfessorCombo
        {
            get { return professorComboBox; }
            set { professorComboBox = value; }
        }

        public Professor ProfessorComboBox
        {
            get { return (Professor)professorComboBox.SelectedItem; }
            set { professorComboBox.SelectedItem = value; }
        }

        public string CapacidadeBox
        {
            get { return capacidadeTurmaText.Text; }
            set { capacidadeTurmaText.Text = value; }
        }

        public DataGridView TurmaGridView
        {
            get { return turmasGridView; }
            set { turmasGridView = value; }
        }

        private void criaTurmaButton_click(object sender, EventArgs e)
        {
            _controller.Insert();
        }

        public void resetFields()
        {
            cursoComboBox.SelectedIndex = 0;
            professorComboBox.SelectedIndex = 0;
            CapacidadeBox = "";
        }

        public void UpdateDataGrid(List<Turma> turmas)
        {
            TurmaGridView.Rows.Clear();

            foreach (var turma in turmas)
            {
                turmasGridView.Rows.Add(
                    turma.Id,
                    turma.Curso.Nome,
                    turma.Professor.Nome,
                    turma.Capacidade
                );
            }
        }

        private void TurmaView_Load(object sender, EventArgs e)
        {
            _controller.Loan();
        }
    }
}
