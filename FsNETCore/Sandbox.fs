namespace FsNETCore

open FSharp.Reflection

module Sandbox =
  let test () =
    FSharpType.IsTuple(typeof<string>) |> ignore
    FSharpType.IsRecord(typeof<string>) |> ignore
