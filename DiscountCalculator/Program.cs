// Write a C# method that receives an order amount and a customer category. Apply the following rules:
// Regular customers receive no discount.
// Silver customers receive 5%.
// Gold customers receive 10%.
// Reject negative order amounts.
// Return the final price after discount.

using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class DiscountCalculator
{
    public decimal Discount(decimal amt, string category)
    {
        if(amt < 0)
        {
            Console.WriteLine("enter valid amount");
        }

        switch(category)
        {
            case "Regular":
            return amt;

            case "Silver":
            return amt - (amt*5)/100;

            case "Gold":
            return amt - (amt*10)/100;
        }

        return amt;
        
    }

}

class Program
{
    static void Main(String[] args)
    {
        DiscountCalculator discountCalculator = new DiscountCalculator();

        decimal result = discountCalculator.Discount(-90, "Regular");

        Console.WriteLine(result);
    }
}