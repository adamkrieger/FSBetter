public class ImmutString
{
    public ImmutString(string value){
        this.Value = value;
    }
    
    public readonly string Value;
}

var bucket = new ImmutString("Really Important Value");
// Error: Readonly field cannot be assigned to.
// bucket.Value = "Another Important Value";

Console.WriteLine(bucket.Value);