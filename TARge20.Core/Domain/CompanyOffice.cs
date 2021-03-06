using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class CompanyOffice
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Comment { get; set; }
    }
}
