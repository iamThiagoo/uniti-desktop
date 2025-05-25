using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.entidades;

namespace TrabalhoAvaliativo.patterns.observer
{
    public interface IObserver
    {
        void Update(Turma turma);
    }
}
