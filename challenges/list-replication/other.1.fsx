open System

let printntimes n printfunc = 
    for i in 1 .. n do printfunc()
           
let n = Int32.Parse(Console.ReadLine())  
let printInts d = printntimes n (fun _ -> printfn "%d" d)
let tryReadInt() = Console.ReadLine() |> Int32.TryParse

tryReadInt()
|> Seq.unfold (function
    | (true, x) -> Some (x, tryReadInt())
    | (false,_) -> None )        
|> Seq.iter printInts