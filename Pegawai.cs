
namespace CSharpFundamentals
{
    public class Pegawai : Person 
    {
        public int PegawaiId {  get; set; }
        public decimal Gaji { get; set; }

        public override string ToString()
        {
            string ret = base.ToString();
            return $"{ret}{Environment.NewLine}{PegawaiId} - {Gaji:c}";
        }
    }
}
