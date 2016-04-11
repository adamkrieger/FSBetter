public class ImmutableItem
{
    private ImmutableItem(){}
    private ImmutableItem(decimal price){
        this.Price = price;
    }
    
    public readonly decimal Price;
    
    public static ImmutableItem Create(decimal price){
        return new ImmutableItem(price);
    }
    
    public decimal WithTax(){
        //Price *= 1.14M; <-- A readonly field cannot be assigned to
        return Price * 1.14M;
    }
}

var shirt = ImmutableItem.Create(10.00M);

var priceWithTax = shirt.WithTax();

Console.WriteLine(priceWithTax);