namespace Bank
{
    public abstract class Account
    {
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public long Pesel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Account(int id, string firstname, string lastname, long pesel)
        {
            Id = id;
            AccountNumber = GenerateAccountNumber(id);
            Balance = 0.0M;
            Pesel = pesel;
            FirstName = firstname;
            LastName = lastname;

        }
        public abstract string TypeName();
        public string GetFullName()
        {
            var fullName = string.Format("{0} {1}", FirstName, LastName);
            return fullName;
        }
        public string GetBalance()
        {
            var balance = string.Format("{0} PLN", Balance);
            return balance;
        }
        public int GenerateAccountNumber(int Id)
        {
            var accountNumber = Id;
            return accountNumber;
        }
        public void ChangeBalance(decimal value)
        {
            Balance += value;
        }
    }
}
