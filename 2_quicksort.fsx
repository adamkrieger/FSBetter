let rec sortIter lt eq gt list pivot =
     printfn "%A : %A : %A : %A" lt eq gt list
     match list with
     | [] -> lt, eq, gt
     | head::tail when head < pivot -> sortIter (head::lt) eq gt tail pivot
     | head::tail when head > pivot -> sortIter lt eq (head::gt) tail pivot
     | head::tail                   -> sortIter lt (head::eq) gt tail pivot
            
let rec quicksort list = 
    match list with
    | []          -> []
    | pivot::tail -> let lt, eq, gt = sortIter [] [] [] tail pivot
                     List.collect id [ quicksort lt; [pivot]; eq; quicksort gt ]
    
[ 4; 9; 2; 4; 4; 9; 19; 23; 9; 3; 2398; 83; 1 ]
|> quicksort
|> printfn "%A"