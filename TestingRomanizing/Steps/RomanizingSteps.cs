using FluentAssertions;
using RomanizingLibrary;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace TestingRomanizing.Features
{
    [Binding]
    public class RomanizingSteps
    {
        private int _number;
        private string _result;

        private readonly Class1 _definition = new Class1();

        [Given(@"input of (.*)")]
        public void GivenInputOf(int num)
        {
            _number = num;
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
