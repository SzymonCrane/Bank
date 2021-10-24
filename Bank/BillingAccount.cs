namespace Bank
{
    public class BillingAccount : Account
    {
        public BillingAccount(int id,  string firstname, string lastname, long pesel) : base (id, firstname, lastname, pesel)
        {
        }
        public void TakeCharge(decimal value)
        {
            Balance -= value;
        }
        public override string TypeName()
        {
            return "Rozliczeniowe";
        }
    }
}
