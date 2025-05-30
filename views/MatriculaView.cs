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
    public partial class MatriculaView : Form
    {
        private MatriculaController _controller;

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
                    matricula.Aluno.Nome,
                    matricula.Turma.Title
                );
            }
        }

        private void MatriculaView_Load(object sender, EventArgs e)
        {
            _controller.Loan();
        }
    }
}
