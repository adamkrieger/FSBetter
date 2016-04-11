type Cheese = { Id:string; Name:string }
let cheeses = 
    [
        { Id = "rwin"; Name = "Red Windsor" };
        { Id = "stil"; Name = "White Stilton"}; 
        { Id = "jarl"; Name = "Norwegian Jarlsburger"}
    ]
    
let getName =
    function 
    | Some cheese -> printfn "%s" cheese.Name
    | None        -> printfn "%s" "Completely out."
    
let pickCheese id =
    List.tryFind (fun item -> item.Id = id)
    >> getName
 
// id:string -> (Cheese[] -> unit)
pickCheese "none" cheeses