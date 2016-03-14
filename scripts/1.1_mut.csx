public static class ValueProcessor
{
    public static void ProcessValue(string value)
    {
        Console.WriteLine(value);
    }
}

var bucket = "Really Important Value";
bucket = "Another Important Value";

ValueProcessor.ProcessValue(bucket);