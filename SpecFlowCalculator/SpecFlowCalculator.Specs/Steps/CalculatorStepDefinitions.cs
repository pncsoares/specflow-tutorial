﻿using Xunit;

namespace SpecFlowCalculator.Specs.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;
    private readonly Calculator _calculator;
    private int _result;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext,  Calculator calculator)
    {
        _scenarioContext = scenarioContext;
        _calculator = calculator;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _calculator.FirstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calculator.SecondNumber = number;
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _result = _calculator.Add();
    }
    
    [When("the two numbers are subtracted")]
    public void WhenTheTwoNumbersAreSubtracted()
    {
        _result = _calculator.Subtract();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        Assert.Equal(result, _result);
    }
}