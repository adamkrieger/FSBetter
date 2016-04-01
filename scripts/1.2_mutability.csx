public class Item{
    public decimal Price;
    
    public decimal WithTax(){
        Price *= 1.14M;
        return Price;
    }
}

Item shirt;
Console.WriteLine(shirt); // Oops #1

shirt = new Item();
Console.WriteLine(shirt.Price); // Oops #2
shirt.Price = 10.00M;

var priceWithTax = shirt.WithTax();
Console.WriteLine(shirt.Price); //Oops #3