using Calculator.Implemenations;
using Calculator.Interfaces;
using Reqnroll.CommonModels;

namespace CalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        private int siffra1;
        private int siffra2;
        private List<(int, int)> parLista;
        private int summa;
        private List<int> summaList;

        [Given("den första siffran är {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.reqnroll.net/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method.

            //Kontrollera att number är en siffra

            siffra1 = number;
        }

        [Given("den andra siffran är {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            // Kontrollera att number är en siffra

            siffra2 = number;
        }
        [Given("att två tal matas in")]
        public void GivenAttTvaTalMatasIn(DataTable dataTable)
        {
            parLista = dataTable.Rows.Select(x => (tal1: int.Parse(x["tal1"]), tal2: int.Parse(x["tal2"]))).ToList();
        }

        [When("de två siffrorna adderas")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ICalculatorService service = new CalculatorService();

            summa = (int)service.Addera((double)siffra1, (double)siffra2);
        }

        [Then("ska resultatet bli {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            //Assert att det blev rätt

            Assert.AreEqual(summa, result);
        }
        [When("de två siffrorna multipliceras från tabell")]
        public void WhenDeTvaSiffrornaMultiplicerasFranTabell()
        {
            ICalculatorService service = new CalculatorService();
            summaList = parLista.Select(x => service.Multiplicera(x.Item1, x.Item2)).ToList();
        }
        [Then("ska resultatet bli:")]
        public void ThenSkaResultatetBli(DataTable dataTable)
        {
            var expectedRes = dataTable.Rows.Select(x => int.Parse(x["resultat"])).ToList();

            Assert.AreEqual(summaList, expectedRes);
        }


        [When("de två siffrorna subtraheras")]
        public void NärTvåSiffrorSubtraheras()
        {
            ICalculatorService service = new CalculatorService();

            summa = service.Subtrahera(siffra1, siffra2);
        }

        [When("de två siffrorna multipliceras")]
        public void NärTvåSiffrorMultipliceras()
        {
            ICalculatorService service = new CalculatorService();

            summaList.Add(service.Multiplicera(siffra1, siffra2));
        }

        public override bool Equals(object? obj)
        {
            return obj is CalculatorStepDefinitions definitions &&
                   siffra1 == definitions.siffra1 &&
                   siffra2 == definitions.siffra2 &&
                   summa == definitions.summa;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(siffra1, siffra2, summa);
        }
    }
}
