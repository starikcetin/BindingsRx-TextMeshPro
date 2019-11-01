# BindingsRx-TextMeshPro
BindingsRx bindings for TextMeshPro.

## Purpose

This library adds BindingsRx bindings for `TMP_Text`, `TMP_InputField`, and `TMP_DropDown`.

## Installation

1. Get these two packages:
    1. https://github.com/mob-sakai/UpmGitExtension
    2. https://github.com/mob-sakai/GitDependencyResolverForUnity
    
2. Install this repo from Unity Package Manager window, inside Unity.

## Usage

Bindings are ported directly from BindingsRx bindings for `Text`, `InputField`, and `DropDown`. 

Therefore, the syntax are exactly the same with one exception:

* uGUI uses `int` as font size, while TMP uses `float`. Therefore, I adjusted the extension methods to accept a `float` instead.

## License

MIT license. Refer to the [LICENSE](/LICENSE) file.

Copyright (c) 2019 S. Tarık Çetin.
