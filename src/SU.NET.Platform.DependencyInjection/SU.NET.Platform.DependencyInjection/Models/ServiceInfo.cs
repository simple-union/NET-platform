using System;

using JetBrains.Annotations;


namespace SU.NET.Platform.DependencyInjection.Models
{
    /// <summary>
    /// Service info.
    /// </summary>
    public sealed class ServiceInfo
    {
        /// <summary>
        /// Gets or sets interface type.
        /// </summary>
        [CanBeNull]
        public Type InterfaceType { get; set; }

        /// <summary>
        /// Gets or sets implementation type.
        /// </summary>
        [CanBeNull]
        public Type ImplementationType { get; set; }
    }
}