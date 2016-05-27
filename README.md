# Nancy.Serialization.NetJSON [![NuGet Version](http://img.shields.io/nuget/v/Nancy.Serialization.NetJSON.svg?style=flat)](https://www.nuget.org/packages/Nancy.Serialization.NetJSON/) [![Build status](https://ci.appveyor.com/api/projects/status/ptv6byra1nq6t614)](https://ci.appveyor.com/project/jbattermann/nancy-serialization-netjson)


Implementations of the ISerialization and IBodyDeserializer interfaces, based on [NetJSON](https://github.com/rpgmaker/NetJSON), for [Nancy](http://nancyfx.org). Because more and more [Performance](https://github.com/rpgmaker/NetJSON#benchmark-how-fast) never hurts.

## Usage

Start of by installing the [Nancy.Serialization.NetJSON](https://www.nuget.org/packages/Nancy.Serialization.NetJSON/) NuGet package:

`PM> Install-Package Nancy.Serialization.NetJSON`

When Nancy detects that the `NetJSONSerializer` and `NetJSONBodyDeserializer` types are available in the AppDomain of your application, it will assume you want to use them, rather than the default ones.

## Thanks

This is basically a port of [Nancy.Serialization.JsonNet](https://github.com/NancyFx/Nancy.Serialization.JsonNet) but replacing the [Json.NET](http://json.codeplex.com/) specific parts with NetJSON's ones and adjusting the tests correspondingly. So thanks to Andreas Håkansson, Steven Robbins and the other original contributors.

Moreover thanks alot to [rpgmaker](https://github.com/rpgmaker) for his work on [NetJSON](https://github.com/rpgmaker/NetJSON).

## Copyright

Copyright © 2016 Jörg Battermann

## License

Nancy.Serialization.NetJSON is licensed under [MIT](http://www.opensource.org/licenses/mit-license.php "Read more about the MIT license form"). Refer to [LICENSE.md](https://github.com/jbattermann/Nancy.Serialization.NetJSON/blob/master/LICENSE.md) for more information.
