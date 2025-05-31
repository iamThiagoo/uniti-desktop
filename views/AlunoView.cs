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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabalhoAvaliativo.views
{
    public partial class AlunoView : Form
    {
        private AlunoController _controller;

        public AlunoView()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }
        public void SetController(AlunoController controller)
        {
            _controller = controller;
        }

        public string NomeBox
        {
            get { return nomeAlunoText.Text; }
            set { nomeAlunoText.Text = value; }
        }

        public string CpfBox
        {
            get { return cpfAlunoText.Text; }
            set { cpfAlunoText.Text = value; }
        }

        public string DataNascimentoBox
        {
            get { return dataNascimentoText.Text; }
            set { dataNascimentoText.Text = value; }
        }

        public DataGridView AlunosGridView
        {
            get { return alunosGridView; }
            set { alunosGridView = value; }
        }

        private void AlunoView_Load(object sender, EventArgs e) {}

        private void criaAlunoButton_click(object sender, EventArgs e)
        {
            _controller.Insert();
        }

        public void resetFields()
        {
            NomeBox = "";
            CpfBox = "";
            DataNascimentoBox = "";
        }

        public void UpdateDataGrid(List<Aluno> alunos)
        {
            AlunosGridView.Rows.Clear();

            foreach (var aluno in alunos)
            {
                AlunosGridView.Rows.Add(
                    aluno.Id,
                    aluno.Nome,
                    aluno.Cpf,
                    aluno.DataNascimento.ToString("dd/MM/yyyy")
                );
            }
        }

        private void alunosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (alunosGridView.Columns[e.ColumnIndex].Name == "btnExcluir" && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir este aluno?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int turmaId = Convert.ToInt32(alunosGridView.Rows[e.RowIndex].Cells["id"].Value);
                    _controller.Delete(turmaId);
                }
            }
        }
    }
}
