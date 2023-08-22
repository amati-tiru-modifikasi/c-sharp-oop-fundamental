using CSharpFundamentals;

Product entity = new()
{
    ProductId = 1,
    Name = "Test",
    StandarCost = 2.99M,
    ListPrice = 6.99M
};


Console.WriteLine(entity.ProductId);
Console.WriteLine(entity.Name);
Console.WriteLine('-');
Console.WriteLine(entity.StandarCost);
Console.WriteLine(entity.ListPrice);
Console.WriteLine(entity.Profit.ToString("c"));
