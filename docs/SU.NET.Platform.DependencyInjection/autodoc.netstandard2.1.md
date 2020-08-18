<a name='assembly'></a>
# SU.NET.Platform.DependencyInjection

## Contents

- [IContainer](#T-SU-NET-Platform-DependencyInjection-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Interfaces.IContainer')
- [Lifestyle](#T-SU-NET-Platform-DependencyInjection-Enums-Lifestyle 'SU.NET.Platform.DependencyInjection.Enums.Lifestyle')
  - [Scoped](#F-SU-NET-Platform-DependencyInjection-Enums-Lifestyle-Scoped 'SU.NET.Platform.DependencyInjection.Enums.Lifestyle.Scoped')
  - [Singleton](#F-SU-NET-Platform-DependencyInjection-Enums-Lifestyle-Singleton 'SU.NET.Platform.DependencyInjection.Enums.Lifestyle.Singleton')
  - [Transient](#F-SU-NET-Platform-DependencyInjection-Enums-Lifestyle-Transient 'SU.NET.Platform.DependencyInjection.Enums.Lifestyle.Transient')
- [Scope](#T-SU-NET-Platform-DependencyInjection-Implementations-Scope 'SU.NET.Platform.DependencyInjection.Implementations.Scope')
  - [DoDispose()](#M-SU-NET-Platform-DependencyInjection-Implementations-Scope-DoDispose 'SU.NET.Platform.DependencyInjection.Implementations.Scope.DoDispose')
- [ServiceInfo](#T-SU-NET-Platform-DependencyInjection-Models-ServiceInfo 'SU.NET.Platform.DependencyInjection.Models.ServiceInfo')
  - [ImplementationType](#P-SU-NET-Platform-DependencyInjection-Models-ServiceInfo-ImplementationType 'SU.NET.Platform.DependencyInjection.Models.ServiceInfo.ImplementationType')
  - [InterfaceType](#P-SU-NET-Platform-DependencyInjection-Models-ServiceInfo-InterfaceType 'SU.NET.Platform.DependencyInjection.Models.ServiceInfo.InterfaceType')

<a name='T-SU-NET-Platform-DependencyInjection-Interfaces-IContainer'></a>
## IContainer `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Interfaces

##### Summary

Container interface.

<a name='T-SU-NET-Platform-DependencyInjection-Enums-Lifestyle'></a>
## Lifestyle `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Enums

##### Summary

Lifestyle.

<a name='F-SU-NET-Platform-DependencyInjection-Enums-Lifestyle-Scoped'></a>
### Scoped `constants`

##### Summary

Scoped lifestyle.

<a name='F-SU-NET-Platform-DependencyInjection-Enums-Lifestyle-Singleton'></a>
### Singleton `constants`

##### Summary

Singleton lifestyle.

<a name='F-SU-NET-Platform-DependencyInjection-Enums-Lifestyle-Transient'></a>
### Transient `constants`

##### Summary

Transient lifestyle.

<a name='T-SU-NET-Platform-DependencyInjection-Implementations-Scope'></a>
## Scope `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Implementations

##### Summary

Scope.

<a name='M-SU-NET-Platform-DependencyInjection-Implementations-Scope-DoDispose'></a>
### DoDispose() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SU-NET-Platform-DependencyInjection-Models-ServiceInfo'></a>
## ServiceInfo `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Models

##### Summary

Service info.

<a name='P-SU-NET-Platform-DependencyInjection-Models-ServiceInfo-ImplementationType'></a>
### ImplementationType `property`

##### Summary

Gets or sets implementation type.

<a name='P-SU-NET-Platform-DependencyInjection-Models-ServiceInfo-InterfaceType'></a>
### InterfaceType `property`

##### Summary

Gets or sets interface type.
