open System

let printntimes n printfunc =
    for i in 1 .. n do printfunc()

let n = Int32.Parse(Console.ReadLine())
let printInts d = printntimes n (fun _ -> printfn "%d" d)

()
|> Seq.unfold
    (fun _ ->
        Console.ReadLine()
        |> Int32.TryParse
        |> function
           | (true,x) -> Some (x, ())
           | (false,_) -> None )
|> Seq.iter printInts