namespace CSharpFundamentals
{
    public class Product {

        public Product() {
            Init();
        }
        // Create constructor
        public Product(int id, string name) {
            ProductId = id;
            Name = name;

            Init();
        }

        public void Init()
        {
            Color = DEFAULT_COLOR;
            StandarCost = 1.00M;
            ListPrice = 5.00M;
            SellStartDate = DateTime.Now;
        }

        // Hardcode
        private const string DEFAULT_COLOR = "Blue";
        public int ProductId { get; set; }
        public string Name { get; set; }

        public string Color { get; set; }

        private decimal _StandarCost;

        public decimal StandarCost
        {
            get { return _StandarCost; }
            set { _StandarCost = value; CalculateProfit(); }
        }

        private decimal _ListPrice;

        public decimal ListPrice
        {
            get { return _ListPrice; }
            set { _ListPrice = value; CalculateProfit(); }
        }

        private decimal _Profit;
        public decimal Profit {
            get { return _Profit; }
        }

        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }

        private void CalculateProfit()
        {
            _Profit = _ListPrice - _StandarCost;
        }

        public int GetNumberOfSellDays()
        {
            return (SellEndDate - SellStartDate).Days;
        }

        public decimal CalculateProfit(decimal price, decimal? cost = 1)
        {
            return price - cost ?? 1;
        }

        public decimal CalculateProfitByValue(decimal price, decimal cost)
        {
            price = 20;
            cost = 5;

            return price - cost;
        }

        public decimal CalculateProfitByRef(ref decimal price, ref decimal cost)
        {
            price = 20;
            cost = 5;

            return price - cost;
        }

    }

 
}

