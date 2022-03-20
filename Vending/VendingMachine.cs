//Write a virtual vending machine where the user can buy different items.
//To buy items they need enough money.
//The user should be able to see what they have bought, goods available in the machine, and how much money they have.
//Implement all of this using an object oriented approach where the User, Bank, VendingMachine, Inventory, and so on are objects that interact with each other through some basic user interface.


public class VendingMachine
{

    public int balance { get; set; }

    //var snacks = new Snack();

    public List<string> Options { get; } = new List<string>
    {
        "help",
        "list",
        "balance",
        "exit"
    };
    public List<Snack> Snacks { get; } = new List<Snack>
         {
             kitkat,
             snickers,
             mars,
             cokeZero
         };



    public void listOptions()
    {
        foreach (var option in Options)
        {
            if (option != "help")
            {
                Console.WriteLine($"{option}");
            }

        }
    }

    public void listSnacks()
    {
        foreach (var snack in snacks)
        {
            Console.WriteLine($"{snack.Name} | {snack.Price} SEK");
        }
    }



    //public void showBalance()
    //{
    //   // Console.Write($"Your balance is: {customer.Balance}SEK");
    //    Console.WriteLine();
    //}

    ////public string purchaseSnack()
    ////{

    ////}

    public void Run()


    {
        Console.WriteLine("Welcome to Snack Time vending machine!");

        string option;

        do
        {
            option = PickOption();

            if (option == "balance")
            {
                //showBalance();
            }
            else if (option == "list")
            {
                listSnacks();
            }
            else if (option == "fill")
            {
                //Console.WriteLine(kitkat.Name);
            }
            else if (option == "help")
            {
                listOptions();
            }

        } while (option != "exit");
    }

    public string PickOption()
    {
        while (true)
        {
            Console.Write("Please make your selection, or type \"help\" for available options.");
            Console.WriteLine();
            listSnacks();


            var input = Console.ReadLine()!;

            if (Options.Contains(input))
            {
                Console.WriteLine("understood");

                return input;
            }

            Console.WriteLine("invalid input.");
        }
    }

}



