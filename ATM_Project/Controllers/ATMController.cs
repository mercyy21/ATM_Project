using ATM_Project.Model;
using Microsoft.AspNetCore.Mvc;

namespace ATM_Project.Controllers
{
    [ApiController]
    [Route("api/cardholder")]
    public class ATMController : ControllerBase
    {
        private IDatabase database;
        public ATMController(IDatabase database)
        {
            this.database = database;
        }
        [HttpPost]
        //Create a CardHolder
        public IActionResult AddCardHolder(CardHolder cardHolder)
        {
            database.AddCardHolder(cardHolder);
            return Ok(cardHolder);
        }

        [HttpGet]
        //Get all Cardholders 
        public List<CardHolder> GetCardHolders()
        {
            return database.GetCardHolders();
        }

        [HttpGet("{cardNumber}")]
        //Get cardholder by Card Number 
        public IActionResult GetCardHolderByCardNumber(string cardNumber)
        {
           CardHolder cardHolder = database.GetCardHolderByCardNumber(cardNumber);
            if(cardHolder == null)
            {
                return NotFound();
            }
            return Ok(cardHolder);
        }

        [HttpPut("{cardNumber}")]
        // Update Card Holder by card number 
        public IActionResult UpdateCardHolder(string cardNumber,[FromBody]UpdateRequest cardHolder)
        {
            bool updatedCardHolder = database.UpdateCardHolder(cardNumber, cardHolder);
            if (updatedCardHolder == false)
            {
                return NotFound();
            }

            return Ok(database.GetCardHolderByCardNumber(cardNumber));
        }

        [HttpDelete("{cardNumber}")]
        //Delete Card Holder by Card number 
        public IActionResult DeleteCardHolderByCardNumber(string cardNumber)
        {
            bool deletedUser = database.DeleteCardHolder(cardNumber);
            if (deletedUser == false)
            {
                return NotFound();
            }
            return NoContent();
        }

       
    }
}
