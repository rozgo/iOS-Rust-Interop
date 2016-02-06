# iOS Rust Native Interop
Examples of how to cross-compile rust for iOS by native interop with Swift and F#.

Before running these examples you will need to follow a few steps to setup your environment.

Install multirust, then:

```
$ git clone git@github.com:rust-lang/rust.git
$ cd rust
$ git submodule update --init --recursive
$ mkdir build
$ cd build
$ ../configure --target=aarch64-apple-ios,x86_64-apple-ios --prefix=$HOME/rustc-ios
$ make -j8 && make install
$ multirust update ios --link-local $HOME/rustc-ios
$ ln -s $HOME/.multirust/toolchains/nightly/bin/cargo $HOME/rustc-ios/bin
```

Many targets are available:
```
armv7-apple-ios,armv7s-apple-ios,i386-apple-ios,aarch64-apple-ios,x86_64-apple-ios
```

After cloning this repo, override the toolchain:
```
$ multirust override ios
```
