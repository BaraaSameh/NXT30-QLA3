using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    class Person
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public override string ToString() => $"{FirstName} {MiddleName ?? ""}".Trim();
    }

}
