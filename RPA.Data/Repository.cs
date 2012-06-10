using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Linq;
using RPA.Core;
using RPA.Model;

namespace RPA.Data
{
    public abstract class Repository<T> : ServiceBase, IRepository<T> where T : Entity
    {
        public Repository(IDataContext dataContext)
            : base(dataContext.AppContext)
        {
            DataContext = dataContext;
            Session = AppContext.GetObject<ISession>();
        }

        public IDataContext DataContext { get; private set; }
        public ISession Session { get; private set; }

        public virtual IList<T> GetAll()
        {
            return Session
                .Query<T>()
                .ToList();
        }

        public virtual T GetById(Guid id)
        {
            return Session
                .Query<T>()
                .Where(o => o.Id == id)
                .FirstOrDefault();
        }

        public virtual void Add(T item)
        {
            Session.Save(item);
        }
        
        public virtual void Update(T item)
        {
            Session.Update(item);
        }
        
        public virtual bool Remove(T item)
        {
             Session.Delete(item);
             return GetById(item.Id) == null;
        }

        public virtual void Clear()
        {
            throw new NotSupportedException();
        }

        public bool Contains(T item)
        {
            return GetById(item.Id) != null;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            GetAll().CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return GetAll().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)GetAll()).GetEnumerator();
        }
    }
}
