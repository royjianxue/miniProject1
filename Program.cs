using System;

namespace miniProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aks user for name and age
            System.Console.Write("Please tell me your first name: ");
            string? firstName = Console.ReadLine();

            System.Console.Write("Please tell me your age: ");
            string? ageText = Console.ReadLine();
            string formattedName;

            if(int.TryParse(ageText, out int age))
            {

                if(firstName.ToUpper() == "BOB" && firstName.ToUpper() == "Sue")
                {
                    formattedName = $"Professor {firstName}";
                }
                else
                {
                    formattedName = $"Student {firstName}";
                }
            
          
                if (age >= 21)
                {
                    System.Console.WriteLine($"Welcome to the class, {formattedName}");

                }
                else
                {
                    System.Console.WriteLine($"We recommend {21 - age} years to start the class.");
                }

            }
            else
            {
                Console.WriteLine("Invalid Age input. Integer required");
            }
      
        }
        
    }
}
