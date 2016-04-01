type Result<'TSuccess, 'TFailure> =
    | Success of 'TSuccess
    | Failure of 'TFailure

type Booking = {
        Id: int;
        Destination: string
    }
    
let idNotZero booking = 
    match booking.Id with
    | 0 -> Failure "Oops, the id is zero."
    | id -> Success booking
    
let input = {
        Id = 2;
        Destination = "France"
    }

input
|> idNotZero
|> function
    | Success booking -> printfn "Have fun in %s!" booking.Destination
    | Failure error -> printfn "%s" error