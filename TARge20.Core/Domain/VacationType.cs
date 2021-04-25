using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class VacationType
    {
        public Guid Id { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public string Type { get; set; }
    }
}
