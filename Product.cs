namespace CSharpFundamentals
{
    public class Product {
        public int ProductId { get; set; }
        public string Name { get; set; }

        private decimal _StandarCost;

        public decimal StandarCost
        {
            get { return _StandarCost; }
            set { _StandarCost = value; _Profit = _ListPrice - _StandarCost; }
        }

        private decimal _ListPrice;

        public decimal ListPrice
        {
            get { return _ListPrice; }
            set { _ListPrice = value; _Profit = _ListPrice - _StandarCost; }
        }

        private decimal _Profit;
        public decimal Profit
        {
            get { return _Profit; }
        }

    }

 
}

