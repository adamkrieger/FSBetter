open System

let printntimes n output =
    for i in 1 .. n do printfn "%s" output

let getN () = Console.ReadLine () |> Int32.Parse

let doWhenNotNull f = 
    function
    | null -> () 
    | "asdf" -> raise (ArgumentException("What does the callstack say?")) |> ignore 
    | value -> f (value)

let rec doAndRecurseOnValidInput f () =
    Console.ReadLine()
    |> doWhenNotNull (fun x -> 
                        f(x)
                        doAndRecurseOnValidInput f ())
    
let n = getN ()
let print = printntimes n
do doAndRecurseOnValidInput print ()