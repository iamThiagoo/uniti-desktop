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
    public partial class MatriculaView : Form
    {
        private MatriculaController _controller;
        private bool loading = true;

        public MatriculaView()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public void SetController(MatriculaController controller)
        {
            _controller = controller;
        }

        public ComboBox TurmaCombo
        {
            get { return turmaComboBox; }
            set { turmaComboBox = value; }
        }

        public Turma TurmaComboBox
        {
            get { return (Turma)turmaComboBox.SelectedItem; }
            set { turmaComboBox.SelectedItem = value; }
        }

        public ComboBox AlunoCombo
        {
            get { return alunoComboBox; }
            set { alunoComboBox = value; }
        }

        public Aluno AlunoComboBox
        {
            get { return (Aluno)alunoComboBox.SelectedItem; }
            set { alunoComboBox.SelectedItem = value; }
        }

        public DataGridView MatriculasGridView
        {
            get { return matriculasGridView; }
            set { matriculasGridView = value; }
        }

        public ComboBox FilterTurmaCombo
        {
            get { return filterTurmaComboBox; }
            set { filterTurmaComboBox = value; }
        }

        public Turma FilterTurmaComboBox
        {
            get { return (Turma)filterTurmaComboBox.SelectedItem; }
            set { filterTurmaComboBox.SelectedItem = value; }
        }

        private void criaMatriculaButton_click(object sender, EventArgs e)
        {
            _controller.Insert();
        }

        public void resetFields()
        {
            turmaComboBox.SelectedIndex = 0;
            alunoComboBox.SelectedIndex = 0;
        }

        public void UpdateDataGrid(List<Matricula> matriculas)
        {
            MatriculasGridView.Rows.Clear();

            foreach (var matricula in matriculas)
            {
                MatriculasGridView.Rows.Add(
                    matricula.Id,
                    matricula.Aluno.Title,
                    matricula.Turma.Title
                );
            }
        }

        private void MatriculaView_Load(object sender, EventArgs e)
        {
            _controller.Loan();
            loading = false;
        }

        private void filterTurmaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            _controller.SearchByTurma();
        }

        private void matriculasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (matriculasGridView.Columns[e.ColumnIndex].Name == "btnExcluir" && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir esta matrícula?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int matriculaId = Convert.ToInt32(matriculasGridView.Rows[e.RowIndex].Cells["id"].Value);
                    _controller.Delete(matriculaId);
                }
            }
        }
    }
}
