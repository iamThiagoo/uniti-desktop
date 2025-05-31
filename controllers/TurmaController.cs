using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class TurmaController
    {
        private TurmaModel _model;
        private CursoModel _cursoModel;
        private ProfessorModel _professorModel;
        private TurmaView _view;

        public TurmaController(TurmaModel model, CursoModel cursoModel, ProfessorModel professorModel, TurmaView view)
        {
            _view = view;
            _model = model;
            _cursoModel = cursoModel;
            _professorModel = professorModel;

            var turmas = _model.Find();
            _view.UpdateDataGrid(turmas);
        }

        public void Loan()
        {
            _view.CursoCombo.DataSource = _cursoModel.Find();
            _view.CursoCombo.DisplayMember = "Nome";
            _view.CursoCombo.ValueMember = "Id";

            var professores = _professorModel.Find();
            _view.ProfessorCombo.DataSource = professores;
            _view.ProfessorCombo.DisplayMember = "Nome";
            _view.ProfessorCombo.ValueMember = "Id";

            _view.FilterCursoCombo.DataSource = _cursoModel.Find();
            _view.FilterCursoCombo.DisplayMember = "Nome";
            _view.FilterCursoCombo.ValueMember = "Id";
        }

        public void Insert()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_view.CursoComboBox.ToString()) || string.IsNullOrWhiteSpace(_view.ProfessorComboBox.ToString()) || string.IsNullOrWhiteSpace(_view.CapacidadeBox))
                {
                    throw new Exception("Por favor, preencha todos os campos obrigatórios.");
                }

                var cursoValue = _view.CursoComboBox;
                var professorValue = _view.ProfessorComboBox;

                if (!int.TryParse(_view.CapacidadeBox.Trim(), out int capacidade) || capacidade <= 0)
                {
                    throw new Exception("Capacidade inválida. Informe um número inteiro positivo.");
                }

                _model.Insert(cursoValue, professorValue, capacidade);

                _view.resetFields();
                var turmas = _model.Find();
                _view.UpdateDataGrid(turmas);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchByCurso()
        {
            var turmas = _model.SearchByCurso(_view.FilterCursoComboBox.Id);
            _view.UpdateDataGrid(turmas);
        }

        public void Delete(int turmaId)
        {
            try
            {
                var turma = _model.Find().FirstOrDefault(m => m.Id == turmaId);
                var command = new TurmaDeleteCommand(DataRepository.Instance, turma);

                command.Execute();
                var turmas = _model.Find();
                _view.UpdateDataGrid(turmas);

                MessageBox.Show(
                    "Turma excluída com sucesso!",
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
