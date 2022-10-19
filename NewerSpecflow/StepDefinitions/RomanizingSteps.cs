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
        private int _number;
        private string _result;

        private readonly Class1 _definition = new Class1();

        //[Given(@"input of (.*)")]
        //public void GivenInputOf(int num)
        //{
        //    _number = num;
        //}
        [Given(@"rawinput was (.*)")]
        public void GivenRawinputWas(int p0)
        {
            _number = p0;

        }


        [When(@"converted to Roman numerals")]
        public void WhenConvertedToRomanNumerals()
        {
            _result = _definition.Romanize(_number);
        }

        [Then(@"Result should be Romanlanguage ""([^""]*)""")]
        public void ThenResultShouldBeRomanlanguage(string res)
        {
        _result.Should().Be(res);
        }



    }
}
