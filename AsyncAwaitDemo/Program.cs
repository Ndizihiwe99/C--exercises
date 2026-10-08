using System;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

public class Program
{
    public static readonly HttpClient client = new HttpClient();
    public static async Task Main(string[] args)
    {
        string url = "https://www.example.com";
        Console.WriteLine($"downloading {url}...");
        
        string html = await client.GetStringAsync(url);

         Console.WriteLine($"downloaded {html.Length} characters from url: {url}");

        Console.WriteLine("Starting async operation demo..");
        int sum = await PerformAsyncOpearation(5, 6);
        Console.WriteLine($"The sum of 5 and 6 is: {sum}");
    //     try
    // {
    //     string content = await File.ReadAllTextAsync("Cynthia logbook.docx");
    //     Console.WriteLine($"Here is your file content: {content}");
    // }
    // catch (FileNotFoundException)
    // {
    //     Console.WriteLine("Cynthia logbook.docx was not found in the current folder.");
    // }
    }

    public static async Task<int> PerformAsyncOpearation(int a, int b)
    {
        await Task.Delay(4000);
        return a + b;
    } 
}