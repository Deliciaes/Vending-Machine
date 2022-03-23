//Write a virtual vending machine where the user can buy different items.
//To buy items they need enough money.
//The user should be able to see what they have bought, goods available in the machine, and how much money they have.
//Implement all of this using an object oriented approach where the User, Bank, VendingMachine, Inventory, and so on are objects that interact with each other through some basic user interface.


public class VendingMachine
{

    public int balance { get; set; }


    public List<string> Options { get; } = new List<string>
    {
        "help",
        "list",
        "balance",
        "exit"
    };

    public List<Snack> snackList = new List<Snack>
    {
        new Snack(1, "KitKat", 12, 10),
        new Snack(2, "hej", 12, 10),
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



    public void listSnack()
    {
        Console.WriteLine("--- Please select by typing corresponding number ---");
        foreach (var item in snackList)
        {
            Console.WriteLine($"{item.Option}: {item.Name} | {item.Price} SEK");
        }
    }


    //public void showBalance()
    //{
    //   // Console.Write($"Your balance is: {customer.Balance}SEK");
    //    Console.WriteLine();
    //}


    public void Run()

    {
        Console.WriteLine($"Welcome to Snack Time vending machine!");

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
                listSnack();
            }
            else if (option == "help")
            {
                listOptions();
            }
            else if (option == "1")
            {
                int number;
                Int32.TryParse(option, out number);

                var selection = from s in snackList
                                where s.Option == number
                                select s;
                foreach (var item in selection)
                {
                    Console.WriteLine($"Thank you for purchasing {item.Name} !");
                }
                break;
            }

        } while (option != "exit");
    }

    public string PickOption()
    {
        while (true)
        {
            Console.Write("Please make your selection, or type \"help\" for available options.");
            Console.WriteLine();
            listSnack();

            var input = Console.ReadLine()!;

            if (Options.Contains(input)|| input == "1"|| input == "2")
            {
                Console.WriteLine("selection confirmed");

                return input;
            }

            Console.WriteLine("invalid input.");
        }
    }

}
