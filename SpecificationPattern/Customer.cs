using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    internal class Customer
    {
        public int Age { get; set; }
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public bool IsAdmin { get; set; }
    }
}
