
// Basic c# question below

// Implement a text formatter system. Write a C# method that receives a raw string and a 
// custom delegate representing a formatting rule. Apply the following rules: reject null 
// or empty strings by throwing an exception; execute the delegate to process the text; 
// and return the modified string.

using System.Security.Cryptography.X509Certificates;

public class TextFormatterSystem
{
    public delegate string Format(string delgteText);

     public string textFormatter(string Text, Format format)
        {
            if(String.IsNullOrEmpty(Text))
            throw new Exception("Enter a valid Text");

            string modifiedString = format.Invoke(Text);

            return modifiedString;
        }
}
public class Program
{
    static void Main(string[] args)
    {
        TextFormatterSystem textFormatterSystem = new TextFormatterSystem();

        string result = textFormatterSystem.textFormatter("", s => s.ToLower());
        Console.WriteLine(result);
    }

}
        