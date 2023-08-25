using CSharpFundamentals;


Product entity = new()
{
    ProductId = 1,
    Name = "Test",
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