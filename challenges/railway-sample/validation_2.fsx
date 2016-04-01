type Booking = {
        Id: int;
        Destination: string;
        Source: string;
    }
    
let idNotZero booking = 
    match booking.Id with
    | 0 -> None
    | id -> Some booking
    
let actuallyGoingSomewhere =
    function
    | None -> None
    | Some booking ->
        booking.Source = booking.Destination
        |> function
            | true -> None
            | false -> Some booking  
    
let input = {
        Id = 2;
        Destination = "France";
        Source = "France"
    }

input
|> idNotZero
|> actuallyGoingSomewhere
|> function
    | Some booking -> printfn "Have fun in %s!" booking.Destination
    | None -> printfn "%s" "Oops!"