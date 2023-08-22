namespace CSharpFundamentals
{
    public class Product {
        public int ProductId { get; set; }
        public string Name { get; set; }

        private decimal _StandarCost;

        public decimal StandarCost
        {
            get { return _StandarCost; }
            set { _StandarCost = value; }
        }

        private decimal _ListPrice;

        public decimal ListPrice
        {
            get { return _ListPrice; }
            set { _ListPrice = value; }
        }

        public decimal Profit => _ListPrice - StandarCost;

    }

 
}

