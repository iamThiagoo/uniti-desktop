using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private bool loading = true;

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

        public ComboBox FilterCursoCombo
        {
            get { return filterCursoComboBox; }
            set { filterCursoComboBox = value; }
        }

        public Curso FilterCursoComboBox
        {
            get { return (Curso)filterCursoComboBox.SelectedItem; }
            set { filterCursoComboBox.SelectedItem = value; }
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
            loading = false;
        }

        private void filterCursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            _controller.SearchByCurso();
        }

        private void turmasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (turmasGridView.Columns[e.ColumnIndex].Name == "btnExcluir" && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir esta turma?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int turmaId = Convert.ToInt32(turmasGridView.Rows[e.RowIndex].Cells["id"].Value);
                    _controller.Delete(turmaId);
                }
            }
        }

        private void cursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
