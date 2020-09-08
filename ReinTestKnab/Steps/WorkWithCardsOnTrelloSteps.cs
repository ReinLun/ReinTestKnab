using TechTalk.SpecFlow;


namespace ReinTestKnab.Steps
{
    [Binding]
    public class WorkWithCardsOnTrelloSteps
    {
        public static string ApiKey = "Vul hier de APIKey in";
        public static string Token =  "Vul hier het Token in";

        [Given(@"the tester create a card")]
        public void GivenTheTesterCreateACard()
        {
            TrelloConnect.CreateCard(ApiKey, Token, "Rein Test Knab", "Te doen", "Rein Kaart", "TestKaart");
            
        }
        
        [Then(@"the tester reads the new card")]
        public void ThenTheTesterReadsTheNewCard()
        {
            TrelloConnect.ReadCard(ApiKey, Token);
        }
        
        [Then(@"the tester updates the new card")]
        public void ThenTheTesterUpdatesTheNewCard()
        {
            TrelloConnect.UpdateCard(ApiKey, Token, "Knab test Rein");
        }
        
        [Then(@"the tester delete the new card")]
        public void ThenTheTesterDeleteTheNewCard()
        {
            TrelloConnect.DeleteCard(ApiKey, Token);
        }
        
        [Then(@"the card does not exists anymore")]
        public void ThenTheTheCardDoesNotExistsAnymore()
        {
            TrelloConnect.ReadCardAgain(ApiKey, Token);
        }

    }
}
