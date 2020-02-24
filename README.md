[![openupm](https://img.shields.io/npm/v/com.starikcetin.bindingsrx-textmeshpro?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.starikcetin.bindingsrx-textmeshpro/)

# BindingsRx-TextMeshPro
BindingsRx bindings for TextMeshPro.

## Purpose

This library adds BindingsRx bindings for `TMP_Text`, `TMP_InputField`, and `TMP_DropDown`.

## Installation

```
npm install -g openupm-cli
openupm add com.starikcetin.bindingsrx-textmeshpro
```

## Usage

Bindings are ported directly from BindingsRx bindings for `Text`, `InputField`, and `DropDown`. 

Therefore, the syntax are exactly the same with one exception:

* uGUI uses `int` as font size, while TMP uses `float`. Therefore, I adjusted the extension methods to accept a `float` instead.

## License

MIT license. Refer to the [LICENSE](/LICENSE) file.

Copyright (c) 2019 S. Tarık Çetin.
