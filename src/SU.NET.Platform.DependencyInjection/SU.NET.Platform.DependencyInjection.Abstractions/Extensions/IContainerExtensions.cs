using System;

using SU.NET.Platform.DependencyInjection.Abstractions.Enums;
using SU.NET.Platform.DependencyInjection.Abstractions.Interfaces;


namespace SU.NET.Platform.DependencyInjection.Abstractions.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IContainer"/>
    /// </summary>
    // ReSharper disable InconsistentNaming
    public static class IContainerExtensions
        // ReSharper restore InconsistentNaming
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="container"></param>
        /// <typeparam name="TPrototype"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        public static void RegisterSingleton<TPrototype, TImplementation>(this IContainer container)
        {
            container.Register<TPrototype, TImplementation>(Lifestyle.Singleton);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="container"></param>
        /// <typeparam name="TPrototype"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        public static void RegisterTransient<TPrototype, TImplementation>(this IContainer container)
        {
            container.Register<TPrototype, TImplementation>(Lifestyle.Transient);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="container"></param>
        /// <typeparam name="TPrototype"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        public static void RegisterScoped<TPrototype, TImplementation>(this IContainer container)
        {
            container.Register<TPrototype, TImplementation>(Lifestyle.Scoped);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="container"></param>
        /// <param name="prototype"></param>
        /// <param name="implementation"></param>
        public static void RegisterSingleton(this IContainer container,
                                             Type prototype,
                                             Type implementation)
        {
            container.Register(prototype, implementation, Lifestyle.Singleton);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="container"></param>
        /// <param name="prototype"></param>
        /// <param name="implementation"></param>
        public static void RegisterTransient(this IContainer container,
                                             Type prototype,
                                             Type implementation)
        {
            container.Register(prototype, implementation, Lifestyle.Transient);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="container"></param>
        /// <param name="prototype"></param>
        /// <param name="implementation"></param>
        public static void RegisterScoped(this IContainer container,
                                          Type prototype,
                                          Type implementation)
        {
            container.Register(prototype, implementation, Lifestyle.Scoped);
        }
    }
}