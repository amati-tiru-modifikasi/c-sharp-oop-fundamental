using CSharpFundamentals;

/*
Product entity = new()
{
    StandarCost = 10M,
    ListPrice = 100M
};

decimal price = 0M;
decimal cost = 0M;

entity.TrialIncreaseByPercentage(1.1M, out price, out cost);

Console.WriteLine(price);
Console.WriteLine(cost);
*/

/*
Product entity = new();

decimal price = 30.99M;
decimal cost = 14.36M;

Console.WriteLine(entity.CalculateProfitByRef(ref price, ref cost).ToString("c"));
Console.WriteLine(price);
Console.WriteLine(cost);
*/

/*
Product entity = new(2, "Car")
{
    SellEndDate = DateTime.Parse("29/8/2023")
};

Console.WriteLine(entity.ProductId);
Console.WriteLine(entity.Name);
Console.WriteLine(entity.Color);
Console.WriteLine('-');
Console.WriteLine(entity.StandarCost);
Console.WriteLine(entity.ListPrice);
Console.WriteLine(entity.Profit.ToString("c"));
Console.WriteLine("Days to sell:" + entity.GetNumberOfSellDays());
Console.WriteLine(entity.CalculateProfit(30.99M, 14.36M).ToString("c"));
Console.WriteLine(entity.CalculateProfit(30.99M).ToString("c"));
Console.WriteLine(entity.CalculateProfit(cost: 14.36M, price: 30.99M ).ToString("c"));
*/

/* SINTAK #2 */
/*
Customer entity = new()
{
    CustomerId = 1,
    FirstName = "Desta",
    LastName = "Hacker",
    CompanyName = "PT Angin Ribu",
    EmailAddress = "mdestafadilah@gmail.com"
};
*/

/* SINTAK #1
entity.CustomerId = 1;
entity.FirstName = "Desta";
entity.LastName = "Hacker";
*/

/*
Console.Write(entity.CustomerId);
Console.Write(" - ");
Console.Write(entity.FirstName);
Console.Write(" ");
Console.Write(entity.LastName);
Console.Write(entity.CompanyName);
Console.Write(entity.EmailAddress);
*/

/*
Customer entity = new();

// entity.SetCreditLimit(100000);
entity.FirstName = "Desta";
entity.LastName = "Hacker";

Console.WriteLine(entity.CreditLimit.ToString("c"));
Console.WriteLine(entity.FullName());
*/

Person entity = new Person()
{
    FirstName = "M Desta",
    LastName = "Fadilah",
    Age = 33
};

Console.WriteLine($"{entity.LastName},{entity.FirstName}");