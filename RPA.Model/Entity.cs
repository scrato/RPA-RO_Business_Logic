using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPA.Model
{
    public abstract class Entity
    {
        private Guid _id;

        protected Entity()
        {

        }

        public virtual Guid Id
        {
            get
            {
                if (_id == Guid.Empty)
                    _id = Guid.NewGuid();
                return _id;
            }
            protected set
            {
                _id = value;
            }
        }
    }
}
