using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgram
{
    internal class Menu
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"ID:{Id} Name:{Name}";
        }
    }
}
