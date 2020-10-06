using System;

using SU.NET.Platform.DependencyInjection.Abstractions.Enums;


namespace SU.NET.Platform.DependencyInjection.Abstractions.Interfaces
{
    /// <summary>
    /// Container interface.
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <typeparam name="TPrototype"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        /// <param name="lifestyle"></param>
        void Register<TPrototype, TImplementation>(Lifestyle lifestyle);

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="prototype"></param>
        /// <param name="implementation"></param>
        /// <param name="lifestyle"></param>
        void Register(Type prototype,
                      Type implementation,
                      Lifestyle lifestyle);
    }
}