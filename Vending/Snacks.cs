public class Snack
    {
        public int  Option { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

    public Snack(int option, string name, int price, int quantity)
        {
            Option = option;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }


