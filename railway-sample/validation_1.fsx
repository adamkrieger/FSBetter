type Booking = { Id: int;
                 Destination: string
               }
    
let idNotZero booking = 
    match booking.Id with
    | 0 -> None
    | id -> Some booking
    
let input = {
        Id = 2;
        Destination = "France"
    }

input
|> idNotZero
|> function
    | Some booking -> printfn "Have fun in %s!" booking.Destination
    | None -> printfn "%s" "Oops!"