#load "hotels.fsx"

let getInput () =
    printfn "%s" "Enter the hotel id."
    System.Console.ReadLine()

let tryFindHotelById hotels id = 
    Array.tryFind (fun (item:Hotels.Hotel) -> item.Id = id) hotels

let printFoundHotelName =
    function
    | Some (hotel:Hotels.Hotel) -> 
            printfn "%s" hotel.Name
            Some hotel
    | None -> 
            printfn "%s" "Not found."
            None
            
let searchPrompt () =
    let search = 
        getInput
        >> tryFindHotelById Hotels.hotelListing
        >> printFoundHotelName
    
    search()