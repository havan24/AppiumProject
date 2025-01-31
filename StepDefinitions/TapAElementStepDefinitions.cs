using System;
using AppiumSpecFlowProject1.Hooks;
using AppiumSpecFlowProject1.Pages;
using TechTalk.SpecFlow;

namespace AppiumSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TapAElementStepDefinitions : TestInitializeUnit
    {
        //ClickPage cp = new ClickPage((OpenQA.Selenium.Appium.Android.AndroidDriver)ScenarioContext.Current["androidContext"]);
        [Given(@"Launch the application")]
        public void GivenLaunchTheApplication()
        {
            Console.WriteLine("User Is On The Home Page");

        }

        [When(@"User taps on the views element")]
        public void WhenUserTapsOnTheViewsElement()
        {
            ClickPage cp = new ClickPage((OpenQA.Selenium.Appium.Android.AndroidDriver)ScenarioContext.Current["androidContext"]);
            cp.ClickViews();
        }

        [Then(@"User is navigated to views page")]
        public void ThenUserIsNavigatedToViewsPage()
        {
            Console.WriteLine("User Is Navigated To Views Page");
        }
        [When(@"User taps on the radio group  element")]
        public void WhenUserTapsOnTheRadioGroupElement()
        {
            ClickPage cp = new ClickPage((OpenQA.Selenium.Appium.Android.AndroidDriver)ScenarioContext.Current["androidContext"]);
            cp.HandlingRadioCheckboxes();
        }



    }
}