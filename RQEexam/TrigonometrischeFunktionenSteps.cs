using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQEexam
{
    [Binding]
    public class TrigonometrischeFunktionenSteps
    {
        double num, erg;

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(Decimal p0)
        {
            num = Math.PI;
        }

        [When(@"I chose sinus")]
        public void WhenIChoseSinus()
        {
            erg = Math.Sin(num);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = erg;
            Assert.Equal(expected, actual,5);
        }

       

        [When(@"I chose cosinus")]
        public void WhenIChoseCosinus()
        {
            erg = Math.Cos(num);
        }

        [When(@"I chose tangens")]
        public void WhenIChoseTangens()
        {
            erg = Math.Tan(num);
        }

      
    }
}
