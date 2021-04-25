using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Tip
    {
        public Guid Id { get; set; }
        public string TipExplanation { get; set; }
        public DateTime Date { get; set; }
        public CompanyOffice CompanyOffice {get;set;}
        public string Comment { get; set; }
    }
}
