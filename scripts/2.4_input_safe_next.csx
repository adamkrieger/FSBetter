#r "0.2_Maybe.dll"
#load "0.1_Cheese.csx"

cheeses
    .TrySingle(cheese => cheese.id == "ched")
    .IfIs(a => Console.WriteLine(a.name))
    .IfIsNot(() => Console.WriteLine("Not found."));
    
0