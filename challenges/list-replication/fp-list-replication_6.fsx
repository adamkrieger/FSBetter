open System

let printntimes n output =
    for i in 1 .. n do printfn "%s" output

let getN () = Console.ReadLine () |> Int32.Parse

let doWhenNotNull f = 
    function
    | null -> None 
    | "asdf" -> raise (ArgumentException("What does the callstack say?"))
                None 
    | value -> Some (f value)

let rec doAndRecurseOnValidInput f () =
    let recurseUnlessNone = function
    | Some _ -> doAndRecurseOnValidInput f ()
    | None -> ()
    
    Console.ReadLine()
    |> doWhenNotNull f
    |> recurseUnlessNone
    
let n = getN ()
let print = printntimes n
let printAndRecurse = doAndRecurseOnValidInput print
do printAndRecurse ()