var kitkat = new Snack("KitKat", 12);
var snickers = new Snack("Snickers", 15);
var mars = new Snack("Mars", 14);
var cokeZero = new Snack("Coke Zero", 18);

var snacks = new List<Snack>()
            {
                kitkat,
                snickers,
                mars,
                cokeZero

            };


foreach (var snack in snacks)
{
    Console.WriteLine($"{snack.Name} | {snack.Price} SEK");
}


class Snack
    {
        public string Name { get; }
        public int Price { get; set; }

        public Snack(string name, int price)
    {
        Name = name;
        Price = price;
    }

 }

