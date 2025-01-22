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
        private int modulo;
        private int rest;
        private List<(int siffra1, int siffra2)> siffrorLista;
        private List<int> resultat;

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

        [Given("att modulo �r {int}")]
        public void GivenTheModuloNumberIs(int number)
        {
            modulo = number;
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

        [When("de tv� siffrorna multipliceras")]
        public void N�rTv�SiffrorMultipliceras()
        {
            ICalculatorService service = new CalculatorService();

            summa = service.Multiplicera(siffra1, siffra2);
        }

        [When("de tv� siffrorna moduleras")]
        public void N�rTv�SifforModuleras()
        {
            var service = new CalculatorService();

            rest = service.Modulo(siffra1, modulo);
        }

        [Then("ska resten bli {int}")]
        public void ThenTheRestenShouldBe(int result)
        {
            Assert.AreEqual(rest, result);
        }

        [Given("f�ljande tal")]
        public void GivenTheFollowingNumbers(DataTable table)
        {
            siffrorLista = table.Rows.Select(x => (int.Parse(x["Siffra ett"]), int.Parse(x["Siffra tv�"]))).ToList();
        }

        [When("talen adderas")]
        public void WhenTalenAdderas()
        {
            resultat = siffrorLista.Select(x => x.siffra1 + x.siffra2).ToList();
        }


        [Then("ska resultatet bli")]
        public void ThenSkaResultatetBli(DataTable dataTable)
        {
            foreach (var res in resultat)
                Assert.AreEqual(res, int.Parse(dataTable.Rows[resultat.IndexOf(res)]["Resultat"]));
        }
    }
}
