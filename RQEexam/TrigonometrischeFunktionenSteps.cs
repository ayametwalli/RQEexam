using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQEexam
{
    [Binding]
    public class TrigonometrischeFunktionenSteps
    {
        int num, erg;

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(Decimal p0)
        {
            num = (int)Math.PI;
        }

        [When(@"I chose sinus")]
        public void WhenIChoseSinus()
        {
            erg = (int)Math.Sin(num);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = erg;
            Assert.Equal(expected, actual);
        }

       

        [When(@"I chose cosinus")]
        public void WhenIChoseCosinus()
        {
            erg = (int)Math.Cos(num);
        }

        [When(@"I chose tangens")]
        public void WhenIChoseTangens()
        {
            erg = (int)Math.Tan(num);
        }

      
    }
}
