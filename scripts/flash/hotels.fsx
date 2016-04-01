type StarRating =
        | One | Two | Three | Four | Five 

type Suite = 
        | King | Queen | TwoQueens

type Hotel = 
    { 
        Id: string; 
        Name: string;
        City: string;
        StarRating: StarRating;
        Suites: Suite[];
    }
    
let hotelListing = 
    [|
        { Id = "roy"; Name = "Royale"; City = "Paris"; StarRating = StarRating.Five; Suites = [| Suite.King; Suite.TwoQueens |] };
        { Id = "mar"; Name = "Marquis"; City = "Paris"; StarRating = StarRating.Three; Suites = [| Suite.King; |] };
        { Id = "arm"; Name = "Arms"; City = "London"; StarRating = StarRating.Three; Suites = [| Suite.King; Suite.Queen; Suite.TwoQueens |] };
        { Id = "win"; Name = "Windsor"; City = "London"; StarRating = StarRating.Four; Suites = [| Suite.King; Suite.TwoQueens |] };
        { Id = "pin"; Name = "Pines"; City = "New York"; StarRating = StarRating.Four; Suites = [| Suite.King; Suite.TwoQueens |] };
        { Id = "inn"; Name = "Inn"; City = "New York"; StarRating = StarRating.Two; Suites = [| Suite.Queen; Suite.TwoQueens |] };
        { Id = "mai"; Name = "Maison"; City = "Paris"; StarRating = StarRating.Two; Suites = [| Suite.Queen; Suite.TwoQueens |] };
    |]