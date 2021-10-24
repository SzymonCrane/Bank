namespace Bank
{
    public class SavingsAccount : Account
    {
    public SavingsAccount(int id, string firstname, string lastname, long pesel) : base (id, firstname, lastname, pesel)
        {
        }
        

        public void SetInterest(decimal interest)
        {
            Balance += Balance * interest;
        }
        public override string TypeName()
        {
            return "Oszczędnościowe";
        }
    }
}
