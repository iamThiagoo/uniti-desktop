using System.Collections.Generic;
using TrabalhoAvaliativo.entidades;

namespace TrabalhoAvaliativo.patterns.observer.turma
{
    internal class TurmaNotifier : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private Turma _turma;

        public TurmaNotifier(Turma turma)
        {
            _turma = turma;
        }

        public void Add(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Remove(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_turma);
            }
        }
    }
}
