AgileCoding.Extensions.Readers
==============================

Overview
--------

AgileCoding.Extensions.Readers is a .NET library that provides several useful extension methods related to XML readers. This package aims to enhance the behavior of XML readers, making them more efficient and easy to work with.

Installation
------------

This library is distributed via NuGet. To install it, use the NuGet package manager console:

bash

`Install-Package AgileCoding.Extensions.Readers -Version 2.0.6`

Features
--------

This library introduces the `ReadToNextElement` extension method for `XmlReader`. This method advances the `XmlReader` to the next 'element' node in the XML document, ignoring any non-element nodes along the way. If the end of the file is reached, the method will return `false`, otherwise it will return `true`.

Usage
-----

Here's an example of how to use this feature in your code:

```csharp
using AgileCoding.Extentions.Readers;
using System.Xml;

// Create a new XmlReader instance
XmlReader reader = XmlReader.Create("example.xml");

// Use the ReadToNextElement extension method
bool result = reader.ReadToNextElement();

// The reader is now positioned at the next 'element' node, or at the end of the file
```

Documentation
-------------

For more detailed information about the usage of this library, please refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.Readers/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, see the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.Readers/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.Readers/blob/main/CONTRIBUTING.md) for more details.