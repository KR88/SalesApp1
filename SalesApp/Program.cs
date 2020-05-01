using System;
using System.ComponentModel.DataAnnotations;

namespace SalesApp
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Allied Pioneer Ltd.");
            while (true)
                Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Print all accounts");
            Console.WriteLine("3. Sell parts");
            Console.WriteLine("4. Purchase parts");
            Console.WriteLine("5. Print all transactions");

            var option = Console.ReadLine();
            switch(option)
            {
                case "0":
                    Console.WriteLine(" Thanks for doing business with us");
                    return;

                case "1":
                    Console.WriteLine(" Account name ");
                    var accountName = Console.ReadLine();
                    Console.WriteLine(" Email address ");
                    var emailAddress = Console.ReadLine();
                    var accountTypes = Enum.GetNames(typeof(TypeOfAccount));
                    for (var i = 0; i < accountTypes.Length; i++)
                    {
                        Console.WriteLine($"{i} . {accountTypes[i]}");
                        var accountType = Enum.Parse<TypeOfAccount>(Console.ReadLine());

                    }


            }

        }
        
    };
}
