open System
​
let printntimes n output =
    for i in 1 .. n do printfn "%s" output
​
let n = Int32.Parse(Console.ReadLine())
let printFunc = printntimes n
​
let rec takeInputAndPrint () =
    let input = Console.ReadLine()
    printFunc input
    takeInputAndPrint()
​
do takeInputAndPrint ()