// Given a list of student scores:

// - Reject scores outside the range 0–100.
// - Use LINQ to select students who scored at least 70.
// - Sort qualifying scores from highest to lowest.
// - Return the average of all valid scores.

class Program
{
    static void Main(String[] args)
    {
        List<int> Scores = new List<int>(){95, 60, 82, 70, 101, -5};
        
        List<int> score = Scores.Where(s => s >= 0 && s <= 100).Where(s => s >= 70). OrderByDescending(s => s).ToList();

        double average = Scores.Count() > 0 ? Scores.Average() : 0;


        foreach(int s in score)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine($"Average: {average}");
    }
}