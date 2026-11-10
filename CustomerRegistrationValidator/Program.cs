// Write a method that accepts a customer name, email address, and age. It should:

// - Reject a blank name.
// - Reject an invalid or blank email address.
// - Reject an age below 18.
// - Return clear validation errors.
// - Allow valid input to proceed.
using System.Security.Cryptography.X509Certificates;
using System;

class CustomerRegistrationValidator
{
    public List<string> CustomerValidation(string name, string email, int age)
        {
            List<string> Errors = new List<string>();
            
                 if(string.IsNullOrWhiteSpace(name))
                 {
                    Errors.Add("Name cant be blank");
                 }
                 
                 if(string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
                {
                    Errors.Add("invalid or blank email address are not allowed");
                }

                 
                 if(age < 18 )
                {
                    Errors.Add("an age below 18 aint allowed");
                }

                return Errors;
       }

    
}

 
class Program
{
    static void Main(string[] args)
    {

        CustomerRegistrationValidator customerRegistrationValidator = new CustomerRegistrationValidator();
        List<string> result = customerRegistrationValidator.CustomerValidation("eugene", "eugy@ME.com", 22);

        if(result.Count == 0)
        {
            Console.WriteLine("All inputs are valid");
        }else
        {
            foreach(string error in result)
        {
            Console.WriteLine(error);
        }
        }

        
    }

        
}


    