using FluentAssertions;
using RomanizingLibrary;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace NewerSpecflow.Features
{
    [Binding]
    public class RomanizingSteps
    {
        private ScenarioContext _scenarioContext;
        public RomanizingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        //private int _number;
        //private string _result;


        //[Given(@"input of (.*)")]
        //public void GivenInputOf(int num)
        //{
        //    _number = num;
        //}
        [Given(@"rawinput was (.*)")]
        public void GivenRawinputWas(int num)
        {
            _scenarioContext.Add("number", num);

        }


        [When(@"converted to Roman numerals")]
        public void WhenConvertedToRomanNumerals()
        {
            Class1 _definition = new Class1();
            try
            {
                _scenarioContext.Add("result", _definition.Romanize(_scenarioContext.Get<int>("number")));
            }
            catch(ArgumentOutOfRangeException e)
            {
                _scenarioContext.Add("error", e);
            }
        }

        [Then(@"Result should be Romanlanguage ""([^""]*)""")]
        public void ThenResultShouldBeRomanlanguage(string res)
        {
            if(res == "*throws exception*")
            {
                _scenarioContext.Get<Exception>("error").Should().NotBeNull();
            }
            else
            _scenarioContext.Get<string>("result").Should().Be(res);
        }



    }
}
