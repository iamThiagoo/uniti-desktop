using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.models;
using TrabalhoAvaliativo.views;

namespace TrabalhoAvaliativo.controllers
{
    public class MatriculaController
    {
        private MatriculaModel _model;
        private AlunoModel _alunoModel;
        private TurmaModel _turmaModel;
        private MatriculaView _view;

        public MatriculaController(MatriculaModel model, AlunoModel alunoModel, TurmaModel turmaModel, MatriculaView view)
        {
            _view = view;
            _model = model;
            _alunoModel = alunoModel;
            _turmaModel = turmaModel;

            var matriculas = _model.Find();
            _view.UpdateDataGrid(matriculas);
        }

        public void Loan()
        {
            _view.AlunoCombo.DataSource = _alunoModel.Find();
            _view.AlunoCombo.DisplayMember = "Nome";
            _view.AlunoCombo.ValueMember = "Id";

            _view.TurmaCombo.DataSource = _turmaModel.Find();
            _view.TurmaCombo.DisplayMember = "Title";
            _view.TurmaCombo.ValueMember = "Id";
        }

        public void Insert()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_view.AlunoComboBox.ToString()) || string.IsNullOrWhiteSpace(_view.TurmaComboBox.ToString()))
                {
                    throw new Exception("Por favor, preencha todos os campos obrigatórios.");
                }

                var alunoValue = _view.AlunoComboBox;
                var turmaValue = _view.TurmaComboBox;

                _model.Insert(alunoValue, turmaValue);
                _view.resetFields();
                var matriculas = _model.Find();
                _view.UpdateDataGrid(matriculas);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
