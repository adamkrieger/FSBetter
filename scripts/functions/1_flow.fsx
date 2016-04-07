open System

let intOrNone input =
    Int32.TryParse(input)
    |> function
       | (true, int) -> Some int
       | (false, _ ) -> None
       
let square x = x * x

[ "1"; "2"; "Threeb"; "4" ]
|> List.choose intOrNone
|> List.map square
|> printfn "%A"