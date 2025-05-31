using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAvaliativo.entidades;

namespace TrabalhoAvaliativo.patterns.observer.turma
{
    public class TurmaObserver : IObserver
    {
        public void Update(Turma turma)
        {
            MessageBox.Show(
                $"A turma '{turma.Title}' atingiu sua capacidade máxima!", "Capacidade Máxima", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }
    }
}
