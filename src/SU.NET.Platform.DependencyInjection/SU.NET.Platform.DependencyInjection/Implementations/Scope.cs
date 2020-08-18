using SU.NET.Platform.Common.Implementations;

using SimpleInjectorScope = SimpleInjector.Scope;


namespace SU.NET.Platform.DependencyInjection.Implementations
{
    /// <summary>
    /// Scope.
    /// </summary>
    public sealed class Scope : CommonObject
    {
        private readonly SimpleInjectorScope _scope;


        internal Scope(SimpleInjectorScope scope)
        {
            _scope = scope;
        }


        /// <inheritdoc />
        protected override void DoDispose()
        {
            _scope?.Dispose();

            base.DoDispose();
        }
    }
}