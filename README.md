# What?

* `Enum.TryParse` を Unity でも使えるようにする

# Why?

* 2017年7月時点の Unity C# は .NET 3.5 を利用しており、 `Enum.TryParse` は .NET 4.0 以降の機能である
    * 一応 Unity 2017 では Experimental の機能として .NET 4.6 は使えるけどね
* チョイチョイ使いたいシーンがあるので、無理矢理実装してみた

# Install

```shell
$ npm install @umm/enum-tryparse
```

# Usage

```csharp
using ForwardCompatibility;

class Sample {
    enum Hoge {
        Unknown,
        Foo,
        Bar,
    }
    void Fuga() {
        Hoge hoge;
        if (!Enum.TryParse("Fuga", out hoge)) {
            hoge = Hoge.Unknown;
        }
    }
}
```

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

