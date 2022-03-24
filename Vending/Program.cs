var customer = new Customer()
{
    Balance = 100
};
var app = new VendingMachine();
app.customer = customer;
app.Run();