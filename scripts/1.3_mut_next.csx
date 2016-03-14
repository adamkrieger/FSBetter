public class ImmutString
{
    public ImmutString(string value){
        this.Value = value;
    }
    
    public readonly string Value;
}

Action<string> processValue = value => Console.WriteLine(value);

var bucket = new ImmutString("Really Important Value");
// bucket.Value = "Another Important Value";

processValue(bucket.Value);