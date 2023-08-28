namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual string GetInfo()
        {
            return $"{LastName},{FirstName} Age= {Age}";
        }

        public override string ToString()
        {
            return $"{FirstName},{LastName}";
        }
    }
}
