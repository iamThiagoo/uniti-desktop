using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.models;
using TrabalhoAvaliativo.views;

namespace TrabalhoAvaliativo.controllers
{
    public class ProfessorController
    {
        private ProfessorModel _model;
        private ProfessorView _view;

        public ProfessorController(ProfessorModel model, ProfessorView view)
        {
            _view = view;
            _model = model;

            var professores = _model.Find();
            _view.UpdateDataGrid(professores);
        }

        public void Insert()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_view.NomeBox) || string.IsNullOrWhiteSpace(_view.AreaBox))
                {
                    throw new Exception("Por favor, preencha todos os campos obrigatórios.");
                }

                string nome = _view.NomeBox.Trim();
                string area = _view.AreaBox.Trim();

                _model.Insert(nome, area);

                _view.resetFields();
                var alunos = _model.Find();
                _view.UpdateDataGrid(alunos);

                // MessageBox.Show("Professor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
