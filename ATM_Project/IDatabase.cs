using ATM_Project.Model;

namespace ATM_Project
{
    public interface IDatabase
    {
        List<CardHolder> GetCardHolders();

        CardHolder AddCardHolder (CardHolder cardHolder);
        CardHolder GetCardHolderByCardNumber (string cardNumber);

        bool UpdateCardHolder(String cardNumber, UpdateRequest cardHolder);
        bool DeleteCardHolder(String cardNumber);


    }
}
