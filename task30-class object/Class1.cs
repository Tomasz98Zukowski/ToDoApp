using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task30_class_object
{
    internal class Person
    {
        public string Name { get; set; }
        public string SurrName { get; set; }
        public int Age { get; set; }


    }

    internal class Square
    {
        public int width;
        public int height;
    }

    internal class Country
    {
        private string Name;
        private string Shortcut;

        public void ChangeData(string name, string shortcut)
        {
            Name = name;
            Shortcut = shortcut;
        }

        public static Country Create(string name, string shortcut)
        {
            Country country = new Country() { Name = name, Shortcut = shortcut };
            return country;
            
        }
        public string ShowName()
        {
            return Name;
        }
           
            
        

        
    }
}
