using CSharpFundamentals;

Product entity = new()
{
    ProductId = 1,
    Name = "Test",
    StandarCost = 55,
    ListPrice = 20
};


Console.WriteLine(entity.ProductId);
Console.WriteLine(entity.Name);
Console.WriteLine('-');
Console.WriteLine(entity.StandarCost);
Console.WriteLine(entity.ListPrice);
