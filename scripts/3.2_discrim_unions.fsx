type StarRating =
        | One | Two | Three | Four | Five 

let commission perNight starRating = 
    match starRating with
    | StarRating.Five -> perNight * 0.13 
    | StarRating.Four -> perNight * 0.11
    | StarRating.Three -> perNight * 0.09
    
printfn "Per Night Commission: %A" (commission 300.0 StarRating.Three)