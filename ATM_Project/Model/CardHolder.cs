namespace ATM_Project.Model
{
    public class CardHolder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public int? Pin { get; set; }
        public double? Balance { get; set; }

        public string getCardNumber() { return CardNumber; }
        public int getPin() { return (int)Pin; }
        public string getFirstName() { return FirstName; }
        public string getLastName() { return LastName; }
        public double getBalance() { return (double)Balance; }
    }
}
