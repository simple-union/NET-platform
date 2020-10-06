<a name='assembly'></a>
# SU.NET.Platform.DependencyInjection.Abstractions

## Contents

- [IContainer](#T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer')
  - [Register(prototype,implementation,lifestyle)](#M-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer-Register-System-Type,System-Type,SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle- 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer.Register(System.Type,System.Type,SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle)')
  - [Register\`\`2(lifestyle)](#M-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer-Register``2-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle- 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer.Register``2(SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle)')
- [IContainerExtensions](#T-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions 'SU.NET.Platform.DependencyInjection.Abstractions.Extensions.IContainerExtensions')
  - [RegisterScoped(container,prototype,implementation)](#M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterScoped-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer,System-Type,System-Type- 'SU.NET.Platform.DependencyInjection.Abstractions.Extensions.IContainerExtensions.RegisterScoped(SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer,System.Type,System.Type)')
  - [RegisterScoped\`\`2(container)](#M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterScoped``2-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer- 'SU.NET.Platform.DependencyInjection.Abstractions.Extensions.IContainerExtensions.RegisterScoped``2(SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer)')
  - [RegisterSingleton(container,prototype,implementation)](#M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterSingleton-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer,System-Type,System-Type- 'SU.NET.Platform.DependencyInjection.Abstractions.Extensions.IContainerExtensions.RegisterSingleton(SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer,System.Type,System.Type)')
  - [RegisterSingleton\`\`2(container)](#M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterSingleton``2-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer- 'SU.NET.Platform.DependencyInjection.Abstractions.Extensions.IContainerExtensions.RegisterSingleton``2(SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer)')
  - [RegisterTransient(container,prototype,implementation)](#M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterTransient-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer,System-Type,System-Type- 'SU.NET.Platform.DependencyInjection.Abstractions.Extensions.IContainerExtensions.RegisterTransient(SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer,System.Type,System.Type)')
  - [RegisterTransient\`\`2(container)](#M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterTransient``2-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer- 'SU.NET.Platform.DependencyInjection.Abstractions.Extensions.IContainerExtensions.RegisterTransient``2(SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer)')
- [Lifestyle](#T-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle 'SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle')
  - [Scoped](#F-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle-Scoped 'SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle.Scoped')
  - [Singleton](#F-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle-Singleton 'SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle.Singleton')
  - [Transient](#F-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle-Transient 'SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle.Transient')
- [Scope](#T-SU-NET-Platform-DependencyInjection-Abstractions-Implementations-Scope 'SU.NET.Platform.DependencyInjection.Abstractions.Implementations.Scope')
- [ServiceInfo](#T-SU-NET-Platform-DependencyInjection-Abstractions-Models-ServiceInfo 'SU.NET.Platform.DependencyInjection.Abstractions.Models.ServiceInfo')
  - [ImplementationType](#P-SU-NET-Platform-DependencyInjection-Abstractions-Models-ServiceInfo-ImplementationType 'SU.NET.Platform.DependencyInjection.Abstractions.Models.ServiceInfo.ImplementationType')
  - [InterfaceType](#P-SU-NET-Platform-DependencyInjection-Abstractions-Models-ServiceInfo-InterfaceType 'SU.NET.Platform.DependencyInjection.Abstractions.Models.ServiceInfo.InterfaceType')

<a name='T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer'></a>
## IContainer `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Abstractions.Interfaces

##### Summary

Container interface.

<a name='M-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer-Register-System-Type,System-Type,SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle-'></a>
### Register(prototype,implementation,lifestyle) `method`

##### Summary

TODO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prototype | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| implementation | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| lifestyle | [SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle](#T-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle 'SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle') |  |

<a name='M-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer-Register``2-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle-'></a>
### Register\`\`2(lifestyle) `method`

##### Summary

TODO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lifestyle | [SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle](#T-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle 'SU.NET.Platform.DependencyInjection.Abstractions.Enums.Lifestyle') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPrototype |  |
| TImplementation |  |

<a name='T-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions'></a>
## IContainerExtensions `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Abstractions.Extensions

##### Summary

Extensions for [IContainer](#T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer')

<a name='M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterScoped-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer,System-Type,System-Type-'></a>
### RegisterScoped(container,prototype,implementation) `method`

##### Summary

TODO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer](#T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer') |  |
| prototype | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| implementation | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterScoped``2-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer-'></a>
### RegisterScoped\`\`2(container) `method`

##### Summary

TODO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer](#T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPrototype |  |
| TImplementation |  |

<a name='M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterSingleton-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer,System-Type,System-Type-'></a>
### RegisterSingleton(container,prototype,implementation) `method`

##### Summary

TODO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer](#T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer') |  |
| prototype | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| implementation | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterSingleton``2-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer-'></a>
### RegisterSingleton\`\`2(container) `method`

##### Summary

TODO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer](#T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPrototype |  |
| TImplementation |  |

<a name='M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterTransient-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer,System-Type,System-Type-'></a>
### RegisterTransient(container,prototype,implementation) `method`

##### Summary

TODO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer](#T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer') |  |
| prototype | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| implementation | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-SU-NET-Platform-DependencyInjection-Abstractions-Extensions-IContainerExtensions-RegisterTransient``2-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer-'></a>
### RegisterTransient\`\`2(container) `method`

##### Summary

TODO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer](#T-SU-NET-Platform-DependencyInjection-Abstractions-Interfaces-IContainer 'SU.NET.Platform.DependencyInjection.Abstractions.Interfaces.IContainer') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TPrototype |  |
| TImplementation |  |

<a name='T-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle'></a>
## Lifestyle `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Abstractions.Enums

##### Summary

Lifestyle.

<a name='F-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle-Scoped'></a>
### Scoped `constants`

##### Summary

Scoped lifestyle.

<a name='F-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle-Singleton'></a>
### Singleton `constants`

##### Summary

Singleton lifestyle.

<a name='F-SU-NET-Platform-DependencyInjection-Abstractions-Enums-Lifestyle-Transient'></a>
### Transient `constants`

##### Summary

Transient lifestyle.

<a name='T-SU-NET-Platform-DependencyInjection-Abstractions-Implementations-Scope'></a>
## Scope `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Abstractions.Implementations

##### Summary

Scope.

<a name='T-SU-NET-Platform-DependencyInjection-Abstractions-Models-ServiceInfo'></a>
## ServiceInfo `type`

##### Namespace

SU.NET.Platform.DependencyInjection.Abstractions.Models

##### Summary

Service info.

<a name='P-SU-NET-Platform-DependencyInjection-Abstractions-Models-ServiceInfo-ImplementationType'></a>
### ImplementationType `property`

##### Summary

Gets or sets implementation type.

<a name='P-SU-NET-Platform-DependencyInjection-Abstractions-Models-ServiceInfo-InterfaceType'></a>
### InterfaceType `property`

##### Summary

Gets or sets interface type.
