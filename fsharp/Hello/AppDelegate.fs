namespace Hello

open System

open UIKit
open Foundation
open CoreGraphics

open System.Runtime.InteropServices
open Microsoft.FSharp.NativeInterop

module Interop =

    [<DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)>]
    extern int32 internal rust_hello ()

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit UIApplicationDelegate ()

    override val Window = null with get, set

    override this.FinishedLaunching (app, options) =
        printfn "I called Rust and got: %A" (Interop.rust_hello ())
        true