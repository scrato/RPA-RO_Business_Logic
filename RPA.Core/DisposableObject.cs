using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPA.Core
{
    public abstract class DisposableObject : IDisposable
    {
        private bool _isDisposed;

        public DisposableObject()
        {
            _isDisposed = false;
        }

        ~DisposableObject()
        {
            if (_isDisposed)
                return;
            Dispose(false);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            _isDisposed = true;
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            if (_isDisposed)
                return;
            Dispose(true);
        }
    }
}
