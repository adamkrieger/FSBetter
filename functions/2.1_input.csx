#load "0.1_Cheese.csx"

public Cheese GetCheese(Cheese[] cheeses, string id){
    Cheese foundCheese = null;
    
    foreach (var cheese in cheeses){
        if(cheese.id == id){
            foundCheese = cheese;
        }
    }
    
    return foundCheese;
}

var cheese = GetCheese(cheeses, "rwin");

Console.WriteLine(cheese.name);