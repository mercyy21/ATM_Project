using ATM_Project;
using ATM_Project.Model;

namespace ATM_ProjectTests;

public class UnitTest1
{
    [Fact]
    public void AddCardHolder_Test()
    {
        //Arrange
        Database database = new Database();
        CardHolder cardHolder = new CardHolder();
        cardHolder.FirstName = "Mercy";
        cardHolder.LastName = "Awopetu";
        cardHolder.CardNumber = "123456578";
        cardHolder.Balance = 10000;
        cardHolder.Pin = 1234;

        //Act
        CardHolder result = database.AddCardHolder(cardHolder);

        //Assert
        Assert.NotNull(result);

    }
}