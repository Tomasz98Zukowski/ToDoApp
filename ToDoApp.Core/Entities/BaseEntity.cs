using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get;internal set; }
    }
}
