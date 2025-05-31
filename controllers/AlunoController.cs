using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models;
using TrabalhoAvaliativo.models.repository;
using TrabalhoAvaliativo.patterns.command.delete;
using TrabalhoAvaliativo.views;

namespace TrabalhoAvaliativo.controllers
{
    public class AlunoController
    {
        private AlunoModel _model;
        private AlunoView _view;

        public AlunoController(AlunoModel model, AlunoView view)
        {
            _view = view;
            _model = model;

            var alunos = _model.Find();
            _view.UpdateDataGrid(alunos);
        }

        public void Insert()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_view.NomeBox) || string.IsNullOrWhiteSpace(_view.CpfBox) || string.IsNullOrWhiteSpace(_view.DataNascimentoBox))
                {
                    throw new Exception("Por favor, preencha todos os campos obrigatórios.");
                }

                if (!DateTime.TryParseExact(_view.DataNascimentoBox, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dataNascimento))
                {
                    throw new Exception("Data de nascimento inválida!");
                }

                if (dataNascimento > DateTime.Now) 
                {
                    throw new Exception("Data de nascimento não pode ser futura.");
                }

                string nome = _view.NomeBox.Trim();
                string cpf = _view.CpfBox.Trim();

                _model.Insert(nome, cpf, dataNascimento);

                _view.resetFields();
                var alunos = _model.Find();
                _view.UpdateDataGrid(alunos);

                // MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(int alunoId)
        {
            try
            {
                var aluno = _model.Find().FirstOrDefault(m => m.Id == alunoId);
                var command = new AlunoDeleteCommand(DataRepository.Instance, aluno);

                command.Execute();
                _view.UpdateDataGrid(_model.Find());

                MessageBox.Show(
                    "Aluno excluído com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
