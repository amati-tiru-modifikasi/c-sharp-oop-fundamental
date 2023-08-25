
namespace CSharpFundamentals
{
    public class Customer
    {

        public Customer() {
            CustomerId = 1;
            FirstName = string.Empty;
            LastName = string.Empty;
            CompanyName = string.Empty;
            EmailAddress = string.Empty;
            _CreditLimit = 500000;
        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _CompanyName;    

        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        private string _EmailAddress;

        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }

        private decimal _CreditLimit;
        public decimal CreditLimit
        {
            get { return _CreditLimit; }
            set { _CreditLimit = value; }
        }

        public void SetCreditLimit(decimal limit)
        {
            _CreditLimit = limit;
        }

        public string FullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
