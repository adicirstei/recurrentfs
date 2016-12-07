#load "mat.fsx"

type BackProp = unit -> unit


type Graph = {
  needsBackprop : bool
  backpropFns : BackProp list
}

let graph nbp = 
  {
    needsBackprop = nbp
    backpropFns = []
  }

let backward g =
  List.rev g.backpropFns
  |> List.iter (fun f -> f())