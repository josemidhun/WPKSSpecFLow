using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace WPKSSpecFLow.Steps
{
    [Binding]
    public class StepsFeatureDisplayInfoMessageCurrentAge
    {
        private ChromeDriver myChromeDriver = new ChromeDriver(@"C:\Learnings\TestAutomation\Tools_Utilities_Packages\Selenium\chromedriver_win32\");

        [Given(@"the User Navigates to Westpac KiwiSaver Scheme Retirement Calculator Page")]
        public void GivenTheUserNavigatesToWestpacKiwiSaverSchemeRetirementCalculatorPage()
        {
            myChromeDriver.Manage().Window.Maximize();

            myChromeDriver.Navigate().GoToUrl("https://www.westpac.co.nz/kiwisaver/calculators/kiwisaver-calculator/");

        }

        [When(@"the User Clicks Information Icon besides Current Age Field")]
        public void WhenTheUserClicksInformationIconBesidesCurrentAgeField()
        {

             myChromeDriver.SwitchTo().Frame(0);
            var varInfoIcon = myChromeDriver.FindElementByXPath("//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Current age']//div[@class='field-info ng-scope']//div[@class='ng-isolate-scope']/button[@type='button']/i[@class='icon']");
             varInfoIcon.Click();
        }

        [Then(@"the User can See the Message is displayed below Current Age Field")]
        public void ThenTheUserCanSeeTheMessageIsDisplayedBelowCurrentAgeField()
        {
           
            
            var varActualInfoMsgCurrentAge = myChromeDriver.FindElementByXPath("//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Current age']//div[@class='message-row ng-scope']/div[@class='field-message message-info ng-binding']/p[.='This calculator has an age limit of 18 to 64 years old.']").Text;
            var varExpectedInfoMsgCurrentAge = "This calculator has an age limit of 64 years old as you need to be under the age of 65 to join KiwiSaver.";
            //var varExpectedInfoMsgCurrentAge = "This calculator has an age limit of 18 to 64 years old.";

            Console.WriteLine("Expected Message CurrentAge is " + varExpectedInfoMsgCurrentAge);
            Console.WriteLine("Actual Message CurrentAge is " + varActualInfoMsgCurrentAge);

            Assert.AreEqual(varActualInfoMsgCurrentAge, varExpectedInfoMsgCurrentAge);
            myChromeDriver.SwitchTo().DefaultContent();
            myChromeDriver.Dispose();
        }



    }
    }
