open System

let n = Console.ReadLine() 
let printntimes x = printf "%s\n" x //todo: add loop
let infiniteLines = Seq.initInfinite (fun _ -> Console.ReadLine()) 
Seq.iter printntimes infiniteLines