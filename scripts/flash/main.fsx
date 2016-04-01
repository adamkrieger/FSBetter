#load "book.fsx"

open System

let menu () =
    printfn "Welcome"
    printfn "1. Search"
    printfn "2. Book"
    printfn "3. Report"

let invalidChoice input =
    printfn "Invalid choice: %s. Please try again." input

let reset () = 
    do menu ()
    let input = Console.ReadLine()
    input.ToString().ToLower()

let rec parseChoice () =
    let choice = reset ()
    
    match choice with
    | "1"
    | "search" -> Book.searchPrompt () |> ignore
    | "2"
    | "book" -> printfn "%s" "Book"
    | "3"
    | "report" -> printfn "%s" "Report"
    | other -> 
        invalidChoice other
        
        match other with
        | "callstack" -> raise (ArgumentException("What does the callstack say?")) |> ignore
        |_ -> () |> ignore
        
        parseChoice ()
        // Uncomment to see the power of tail recursion
        //()

let main =
    parseChoice ()
    