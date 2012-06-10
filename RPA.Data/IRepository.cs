using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPA.Core;
using RPA.Model;

namespace RPA.Data
{
    public interface IRepository<T> : IServiceBase, ICollection<T> where T : Entity
    {
        IDataContext DataContext { get; }
        IList<T> GetAll();
        T GetById(Guid id);
        void Update(T item);
    }
}
