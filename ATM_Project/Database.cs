using ATM_Project.Model;

namespace ATM_Project
{
    public class Database : IDatabase
    {
        private List<CardHolder> _cards = new List<CardHolder>();
        public CardHolder AddCardHolder(CardHolder cardHolder)
        {
            _cards.Add(cardHolder);
            return cardHolder;
        }

        public List<CardHolder> GetCardHolders()
        {
            return _cards;
        }


        public bool UpdateCardHolder(string cardNumber,UpdateRequest cardHolder)
        {
            CardHolder existingCardHolder = _cards.FirstOrDefault(a => a.CardNumber == cardNumber);
            if (existingCardHolder == null)
            {
                return false;
            }
            existingCardHolder.FirstName = cardHolder.FirstName ?? string.Empty;
            existingCardHolder.LastName = cardHolder.LastName ?? string.Empty;
            existingCardHolder.Pin = cardHolder.Pin.HasValue ? cardHolder.Pin : null;
            existingCardHolder.Balance = cardHolder.Balance.HasValue ? cardHolder.Balance : null;
            return true;
        }

        public bool DeleteCardHolder(string cardNumber)
        {
            CardHolder existingUser = _cards.FirstOrDefault(a => a.CardNumber == cardNumber);
            if(existingUser == null) { return false; }
            _cards.Remove(existingUser);
            return true;
        }

        public CardHolder GetCardHolderByCardNumber(string cardNumber)
        {
            var existingUser = _cards.FirstOrDefault(a => a.CardNumber == cardNumber);
            return existingUser;
        }
    }
}
