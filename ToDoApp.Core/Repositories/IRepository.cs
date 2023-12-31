using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.Entities;

namespace ToDoApp.Core.Repositories
{
    internal interface IRepository<T>
        where T : BaseEntity
    {
        int Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T? GetValue(int id);
        IReadOnlyList<T> GetAll();
    }
}
