open System

let rnd = new Random()

let randf a b = rnd.NextDouble() * (b - a) + a