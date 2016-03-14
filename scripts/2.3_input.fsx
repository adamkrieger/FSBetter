type Cheese = { Id:string; Name:string }
let cheeses = 
    [|
        { Id = "rwin"; Name = "Red Windsor" };
        { Id = "stil"; Name = "White Stilton"}; 
        { Id = "jarl"; Name = "Norwegian Jarlsburger"}
    |]
    
let pickCheese id =
    Array.tryFind (fun item -> item.Id = id)
    >> function 
       | Some cheese -> printfn "%s" cheese.Name
       | _           -> printfn "%s" "Completely out."
 
// id:string -> (Cheese[] -> unit)
pickCheese "none" cheeses