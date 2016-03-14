#load "0.1_Cheese.csx"

public bool GetCheese(Cheese[] cheeses, string id,
    out Cheese notAtAllObviousActualValue){
        
    foreach (var cheese in cheeses){
        if(cheese.id == id){
            notAtAllObviousActualValue = cheese;
            return true;
        }
    }
    
    notAtAllObviousActualValue = null;
    return false;
}

string outputMessage = string.Empty;
Cheese cheese = null;

if(GetCheese(cheeses, "none", out cheese)){
    outputMessage = cheese.name;    
}
else{
    outputMessage = "Could not find cheese.";
}

Console.WriteLine(outputMessage);