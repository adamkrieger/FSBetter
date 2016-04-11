type Booking = {
        Id: int;
        Destination: string;
        Source: string;
    }
    
let idNotZero booking = 
    match booking.Id with
    | 0 -> None
    | id -> Some booking
    
let actuallyGoingSomewhere booking =
    booking.Source = booking.Destination
    |> function
       | true -> None
       | false -> Some booking  
       
let addPlanet booking =
    Some {
        Id = booking.Id;
        Source = booking.Source + ", Earth";
        Destination = booking.Destination + ", Earth";
    }
    
let input = {
        Id = 2;
        Destination = "France";
        Source = "France"
    }

input
|> idNotZero
|> Option.bind actuallyGoingSomewhere
|> Option.bind addPlanet
|> function
    | Some booking -> printfn "Have fun in %s!" booking.Destination
    | None -> printfn "%s" "Oops!"