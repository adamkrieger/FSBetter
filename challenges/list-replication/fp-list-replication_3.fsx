open System

let printntimes n output =
    for i in 1 .. n do printfn "%s" output
    
let n = Console.ReadLine() |> int

//rec is used to mark this function as recursive
let rec takeInputAndPrint () =
    let input = Console.ReadLine()
    if input <> null then
        printntimes n input
        takeInputAndPrint()

do takeInputAndPrint()