type StarRating =
        | One | Two | Three | Four | Five 
        
type GolfScore =
        | Eight | Seven | Six | Five
        | Four | Three | Two | One
        
let starTest = StarRating.Five > StarRating.Four
let golfTest = GolfScore.One > GolfScore.Three

let commission perNight starRating = 
    match starRating with
    | StarRating.Five -> perNight * 0.13 
    | StarRating.Four -> perNight * 0.11
    | StarRating.Three -> perNight * 0.09
    | StarRating.Two -> perNight * 0.07
    | StarRating.One -> perNight * 0.05
    
printfn "Per Night Commission: %A" (commission 300.0 StarRating.Three)