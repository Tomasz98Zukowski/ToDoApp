using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.DTO;

namespace ToDoApp.Core.Services
{
    public interface IService <T>
        where T : class, IBaseDto
    {
    }
}
