using System;

namespace SCIPA.Data.Repository
{
    public class Base
    {
        public class BaseLogic : IDisposable
        {
            // Flag: Has Dispose already been called?
            bool disposed = false;

            // Public implementation of Dispose pattern callable by consumers.
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            // Protected implementation of Dispose pattern.
            protected virtual void Dispose(bool disposing)
            {
                if (disposed)
                    return;

                disposed = true;
            }
        }
    }
}