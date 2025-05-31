using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAvaliativo.patterns.adapter;

namespace TrabalhoAvaliativo.patterns.template
{
    public abstract class Report
    {
        protected IAdapter _adapter;

        public Report(IAdapter adapter)
        {
            _adapter = adapter;
        }

        public void Generate()
        {
            var data = FetchData();
            var content = BuildContent(data);
            Export(content);
        }

        protected abstract string FetchData();

        protected abstract string BuildContent(string data);

        protected virtual void Export(string content)
        {
            _adapter.Export(content);
        }
    }
}
