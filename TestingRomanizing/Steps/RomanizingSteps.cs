using System;
using TechTalk.SpecFlow;

namespace TestingRomanizing.Features
{
    [Binding]
    public class RomanizingSteps
    {
        [Given(@"input of (.*)")]
        public void GivenInputOf(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"converted to Roman numerals")]
        public void WhenConvertedToRomanNumerals()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
