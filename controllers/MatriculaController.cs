using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models;
using TrabalhoAvaliativo.models.repository;
using TrabalhoAvaliativo.patterns.adapter;
using TrabalhoAvaliativo.patterns.command.delete;
using TrabalhoAvaliativo.patterns.observer.turma;
using TrabalhoAvaliativo.patterns.template;
using TrabalhoAvaliativo.views;

namespace TrabalhoAvaliativo.controllers
{
    public class MatriculaController
    {
        private MatriculaModel _model;
        private AlunoModel _alunoModel;
        private TurmaModel _turmaModel;
        private MatriculaView _view;
        private List<Matricula> matriculas;

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
            _view.AlunoCombo.DisplayMember = "Title";
            _view.AlunoCombo.ValueMember = "Id";

            _view.TurmaCombo.DataSource = _turmaModel.Find();
            _view.TurmaCombo.DisplayMember = "Title";
            _view.TurmaCombo.ValueMember = "Id";

            _view.FilterTurmaCombo.DataSource = _turmaModel.Find();
            _view.FilterTurmaCombo.DisplayMember = "Title";
            _view.FilterTurmaCombo.ValueMember = "Id";
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

                var matriculasTurma = _model.Find().Where(m => m.Turma.Id == turmaValue.Id).Count();
                
                if (matriculasTurma == turmaValue.Capacidade)
                {
                    var notifier = new TurmaNotifier(turmaValue);
                    notifier.Add(new TurmaObserver());
                    notifier.Notify();
                }

                 matriculas = _model.Find();
                _view.UpdateDataGrid(matriculas);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchByTurma()
        {
            var matriculas = _model.SearchByTurma(_view.FilterTurmaComboBox.Id);
            _view.UpdateDataGrid(matriculas);
        }

        public void exportPDF()
        {
            var matric = _model.Find();
            var report = new MatriculaReport(new TxtAdapter(), matric);
            report.Generate();
            MessageBox.Show(
                "PDF exportado com sucesso!", 
                "Exportação", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void exportCSV()
        {
            var report = new MatriculaReport(new CsvAdapter(), matriculas);
            report.Generate();
            MessageBox.Show(
                "CSV exportado com sucesso!", 
                "Exportação", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void Delete(int matriculaId)
        {
            try
            {
                var matricula = _model.Find().FirstOrDefault(m => m.Id == matriculaId);
                var command = new MatriculaDeleteCommand(DataRepository.Instance, matricula);

                command.Execute();
                matriculas = _model.Find();
                _view.UpdateDataGrid(matriculas);

                MessageBox.Show(
                    "Matrícula excluída com sucesso!", 
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
