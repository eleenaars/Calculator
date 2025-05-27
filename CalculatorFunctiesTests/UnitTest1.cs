using CalculatorFuncties; 

namespace CalculatorFunctiesTests
{
    public class UnitTest1
    {
        [Fact] //Geeft aan dat dit een enkele test is zonder parameters.
        public void BerekenResultaat_TweeGetallenOptellen_GeeftCorrectAntwoord()
        {
            //Arrange – je zet je input klaar.
            string invoer = "3+5";

            //Act – je roept de methode aan die je wilt testen.
            string resultaat = Class1.BerekenResultaat(invoer);

            //Assert – je controleert of het resultaat klopt.
            Assert.Equal("8", resultaat);
        }


        [Theory]
        [InlineData("3+5", "8")]
        [InlineData("10-4", "6")]
        [InlineData("7+2-3", "6")]
        public void BerekenResultaat_VerschillendeBerekeningen_GeeftCorrectAntwoord(string invoer, string verwacht)
        {
            string resultaat = Class1.BerekenResultaat(invoer);
            Assert.Equal(verwacht, resultaat);
        }

    }
}






