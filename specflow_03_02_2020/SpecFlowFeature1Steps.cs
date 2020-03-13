using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;


namespace specflow_03_02_2020
{
    [Binding]
    [TestFixture]   
    public class SpecFlowFeature1Steps
    {

        IWebDriver _driver;
        [Test]
        [Given(@"I have navigated to the google search page")]
        
        public void GivenIHaveNavigatedToTheGoogleSearchPage()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("http://www.google.com");


            //ScenarioContext.Current.Pending();
        }


        [Test]
        [When(@"I enter the word Specflow")]
        
            public void WhenIEnterTheWordSpecflow()
        {
            IWebElement GSearch = _driver.FindElement(By.XPath("/html/body/div/div[4]/form/div[2]/div[1]/div[1]/div/div[2]/input"));
            GSearch.SendKeys("Specflow");
            //ScenarioContext.Current.Pending();
        }


        [Test]
        [When(@"I click the Search button")]
        
        public void WhenIClickTheSearchButton()
        {
            //ScenarioContext.Current.Pending();
        }

        [Test]
        [Then(@"I should be shown the Search results page")]
        
        public void ThenIShouldBeShownTheSearchResultsPage()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
