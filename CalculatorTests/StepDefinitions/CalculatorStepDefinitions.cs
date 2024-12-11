using Calculator.Implemenations;
using Calculator.Interfaces;

namespace CalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        private int siffra1;
        private int siffra2;
        private int summa;

        [Given("den f�rsta siffran �r {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.reqnroll.net/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method.

            //Kontrollera att number �r en siffra

            siffra1 = number;
        }

        [Given("den andra siffran �r {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            // Kontrollera att number �r en siffra

            siffra2 = number;
        }

        [When("de tv� siffrorna adderas")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ICalculatorService service = new CalculatorService();

            summa = (int)service.Addera((double)siffra1, (double)siffra2);
        }

        [Then("ska resultatet bli {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            //Assert att det blev r�tt

            Assert.AreEqual(summa, result);
        }


        [When("de tv� siffrorna subtraheras")]
        public void N�rTv�SiffrorSubtraheras()
        {
            ICalculatorService service = new CalculatorService();

            summa = service.Subtrahera(siffra1, siffra2);
        }
    }
}
