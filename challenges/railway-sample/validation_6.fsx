type Result<'TSuccess, 'TFailure> =
    | Success of 'TSuccess
    | Failure of 'TFailure
    
let bind f =
    fun eitherInput ->
        match eitherInput with
        | Success x -> f x
        | Failure x -> Failure x

type Booking = {
        Id: int;
        Destination: string;
        Source: string;
    }
    
let idNotZero booking = 
    match booking.Id with
    | 0 -> Failure "Oops, the id is zero."
    | id -> Success booking
    
let actuallyGoingSomewhere booking =
    booking.Source = booking.Destination
    |> function
       | true -> Failure "There's no reason to leave!"
       | false -> Success booking
       
let addPlanet booking =
    Success {
        Id = booking.Id;
        Source = booking.Source + ", Earth";
        Destination = booking.Destination + ", Earth";
    }
    
let input = {
        Id = 2;
        Destination = "France";
        Source = "France";
    }

input
|> idNotZero
|> bind actuallyGoingSomewhere
|> bind addPlanet
|> function
    | Success booking -> printfn "Have fun in %s!" booking.Destination
    | Failure error -> printfn "%s" error