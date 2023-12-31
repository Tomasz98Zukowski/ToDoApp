using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.Entities;

namespace ToDoApp.Core.Repositories
{
    internal sealed class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly Dictionary<string, List<T>> _entities = new();
        public int Add(T entity)
        {
            var type = typeof(T);
            var constainsList = _entities.TryGetValue(type.Name, out var list);
            if (!constainsList)
            {
                entity.Id = 1;
                list = new List<T>() { entity };
                return entity.Id;
            }
            entity.Id = list![^1].Id+1;
            list.Add(entity);
            return entity.Id;
        }

        public void Delete(T entity)
        {
           var type = typeof(T);
           _entities.TryGetValue(type.Name, out var list);
           list?.Remove(entity);
        }

        public IReadOnlyList<T> GetAll()
        {
            var type = typeof(T);
            _entities.TryGetValue(type.Name,out var list);
            return list ?? new List<T>();
        }

        public T? GetValue(int id)
        {
            var type = typeof(T);
            var constainsList = _entities.TryGetValue(type.Name, out var list);
            if (!constainsList)
            {               
                return null;
            }
            foreach (var item in list!)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
