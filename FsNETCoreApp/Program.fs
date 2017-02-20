open FsNETCore

[<EntryPoint>]
let main _ =
  Sandbox.test () |> printfn "%b"
  Sandbox2.test ()
  0

