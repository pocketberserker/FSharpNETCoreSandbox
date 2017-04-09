module Tests

open System

let ``module: int value`` = 1

let ``module: string value`` = "string"

type Foo = {
  V: int
}
with
  static member ``static property: record`` = { V = 1 }

let ``module: record`` = { V = 1 }

[<Struct>]
type Bar = {
  V: int
}
with
  static member ``static property: struct record`` = { V = 1 }

let ``module: struct record`` = { V = 1 }
