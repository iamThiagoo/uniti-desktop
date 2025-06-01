using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.entidades;
using TrabalhoAvaliativo.models;
using TrabalhoAvaliativo.models.repository;
using TrabalhoAvaliativo.patterns.command.delete;
using TrabalhoAvaliativo.patterns.template;
using TrabalhoAvaliativo.views;

namespace TrabalhoAvaliativo.controllers
{
    public class CursoController
    {
        private CursoModel _model;
        private CursoView _view;

        public CursoController(CursoModel model, CursoView view)
        {
            _view = view;
            _model = model;

            var cursos = _model.Find();
            _view.UpdateDataGrid(cursos);
        }

        public void Insert()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_view.NomeBox) || string.IsNullOrWhiteSpace(_view.DescricaoBox))
                {
                    throw new Exception("Por favor, preencha todos os campos obrigatórios.");
                }

                string nome = _view.NomeBox.Trim();
                string descricao = _view.DescricaoBox.Trim();

                _model.Insert(nome, descricao);
                _view.resetFields();
                var cursos = _model.Find();
                _view.UpdateDataGrid(cursos);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(int cursoId)
        {
            try
            {
                var curso = _model.Find().FirstOrDefault(m => m.Id == cursoId);
                var command = new CursoDeleteCommand(DataRepository.Instance, curso);

                command.Execute();
                var cursos = _model.Find();
                _view.UpdateDataGrid(cursos);

                MessageBox.Show(
                    "Curso excluído com sucesso!",
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

        public void GenerateReportTxt()
        {
            var report = new MatriculaCursoReportTxt();
            report.Generate();

            MessageBox.Show(
                "Relatório .txt gerado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void GenerateReportCsv()
        {
            var report = new MatriculaCursoReportCsv();
            report.Generate();

            MessageBox.Show(
                "Relatório .csv gerado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
