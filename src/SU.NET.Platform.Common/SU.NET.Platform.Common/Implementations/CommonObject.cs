using System;

using SU.NET.Platform.Common.Interfaces;


namespace SU.NET.Platform.Common.Implementations
{
    /// <summary>
    /// Базовый disposable-объект.
    /// </summary>
    public class CommonObject : ICommonObject
    {
        /// <inheritdoc />
        public bool IsDisposed { get; private set; }


        /// <summary>
        /// Finalizes a current instance.
        /// </summary>
        ~CommonObject()
        {
            try
            {
                DoFinalize();
            }
            finally
            {
                GC.SuppressFinalize(this);
            }
        }


        /// <inheritdoc />
        public void Dispose()
        {
            if (!IsDisposed)
            {
                lock (this)
                {
                    if (!IsDisposed)
                    {
                        try
                        {
                            DoDispose();
                        }
                        finally
                        {
                            GC.SuppressFinalize(this);

                            IsDisposed = true;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Dispose current instance.
        /// </summary>
        protected virtual void DoDispose() { }

        /// <summary>
        /// Finalize current instance.
        /// </summary>
        protected virtual void DoFinalize() { }
    }
}