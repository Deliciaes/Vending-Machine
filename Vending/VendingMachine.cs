internal class VendingMachine
{
    public Customer customer;
    public List<string> Options { get; } = new List<string>
    {
        "help",
        "list",
        "balance",
        "exit",
    };

    public List<string> SnackCodes { get; } = new List<string>
    {
        "1",
        "2"
    };

    public List<Snack> snackList = new List<Snack>
    {
        new Snack(1, "KitKat", 12, 0),
        new Snack(2, "Snickers", 12, 10),
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
        Console.WriteLine("--- Please select by typing corresponding number ---");
        foreach (var item in snackList)
        {
            Console.WriteLine($"{item.Option}: {item.Name} | {item.Price} SEK | {item.Quantity} available.");
        }
    }

    public void showBalance()
    {
        Console.Write($"Your balance is: {customer.Balance} SEK");
        Console.WriteLine();
    }

    public void Run()

    {
        Console.WriteLine($"Welcome to Snack Time vending machine!");

        string option;

        do
        {
            option = PickOption();

            if (option == "balance")
            {
                showBalance();
            }
            else if (option == "list")
            {
                listSnacks();
            }
            else if (option == "help")
            {
                listOptions();
            }
            else if (SnackCodes.Contains(option))
            {
                int number;
                Int32.TryParse(option, out number);

                var selection = from s in snackList
                                where s.Option == number
                                select s;
                foreach (var item in selection)
                {
                    if (item.Quantity == 0)
                    {
                        Console.WriteLine("There are none left! Please select a different snack.");
                    }
                    else
                    {
                        if(customer.Balance >= item.Price)
                        {
                            item.Quantity -= 1;
                            customer.Balance -= item.Price;
                            Console.WriteLine($"Thank you for purchasing {item.Name}! There are {item.Quantity} left and you have {customer.Balance} SEK left.");
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money!!");
                        }
                    }
                }
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

            if (Options.Contains(input)|| SnackCodes.Contains(input))
            {
                Console.WriteLine("selection confirmed");

                return input;
            }

            Console.WriteLine("invalid input.");
        }
    }
}
