using System;


namespace SU.NET.Platform.Common.Interfaces
{
    /// <summary>
    /// Интерфейс базового disposable-объекта.
    /// </summary>
    public interface ICommonObject : IDisposable
    {
        /// <summary>
        /// Gets disposed state.
        /// </summary>
        bool IsDisposed { get; }
    }
}