using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace WPKSSpecFLow.Steps
{
    [Binding]
    public class StepsWestpacKiwiSaverProjectedBalance
    {
        private ChromeDriver myChromeDriver = new ChromeDriver(@"C:\Learnings\TestAutomation\Tools_Utilities_Packages\Selenium\chromedriver_win32\");
        [Given(@"the User Navigate to Westpac KiwiSaver Retirement Calculator Page Calculator Page")]
        public void GivenTheUserNavigateToWestpacKiwiSaverRetirementCalculatorPageCalculatorPage()
        {
            myChromeDriver.Manage().Window.Maximize();
            myChromeDriver.Navigate().GoToUrl("https://www.westpac.co.nz/kiwisaver/calculators/kiwisaver-calculator/");
            myChromeDriver.SwitchTo().Frame(0);
        }
        
        [Given(@"the User CurrentAge is (.*)")]
        public void GivenTheUserCurrentAgeIs(string p0)

        {
            string strCurrentAge = p0;
            if (strCurrentAge != "")
            {

                string strXpathCurrentAge = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Current age']//div[@class='control-cell-wrapper']/div[1]/div[@type='integer']/div[1]/div//input[@type='text']";
                IWebElement varCurrentAge = myChromeDriver.FindElementByXPath(strXpathCurrentAge);
                varCurrentAge.SendKeys(p0);
            }
            else
            {

                Console.WriteLine("CurrentAge is not entered");
            }



        }
        
        [Given(@"the User Employment Status is (.*)")]
        public void GivenTheUserEmploymentStatusIs(string p0)
        {
            string strEmploymentStatus = p0;
            if (strEmploymentStatus != "")
            {

                String varEmploymentStatus = p0;
                Console.WriteLine(varEmploymentStatus);
                string strXpathEmploymentStatus = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Employment status']//div[@class='control-cell']/div/div/div[@class='control-well']/div";
                IWebElement varEmploymentStatusEmployed = myChromeDriver.FindElementByXPath(strXpathEmploymentStatus);
                varEmploymentStatusEmployed.Click();
                IWebElement varEmploymentStatusSelect = myChromeDriver.FindElementByXPath(strXpathEmploymentStatus);


                if (varEmploymentStatus is "Employed")
                {

                    string strXpathSalaryEmployedStatus = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']//div[@label='Employment status']//div[@class='control-cell']/div/div/div[@class='dropdown']/ul[@class='option-list']/li[@value='employed']/div[@class='label']";
                    IList<IWebElement> lstSalaryEmployedStatus = varEmploymentStatusSelect.FindElements(By.XPath(strXpathSalaryEmployedStatus));

                    ListOptionsSelect(lstSalaryEmployedStatus, varEmploymentStatus);

                }
                else if (varEmploymentStatus is "Self-employed")
                {

                    string strXpathSelfEmployedStatus = "//html[@id='ng-app']//div[@id='widget']//div[@label='Employment status']//div[@class='control-cell']/div/div/div[@class='dropdown']/ul[@class='option-list']/li[@value='self-employed']/div[@class='label']/span[@class='ng-scope']";
                    IList<IWebElement> lstSelfEmployedStatus = varEmploymentStatusSelect.FindElements(By.XPath(strXpathSelfEmployedStatus));

                    ListOptionsSelect(lstSelfEmployedStatus, varEmploymentStatus);
                }
                else if (varEmploymentStatus is "Not employed")
                {

                    string strXpathNotEmployedStatus = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']//div[@label='Employment status']//div[@class='control-cell']/div/div/div[@class='dropdown']/ul[@class='option-list']/li[@value='not-employed']/div[@class='label']";
                    IList<IWebElement> lstNotEmployedStatus = varEmploymentStatusSelect.FindElements(By.XPath(strXpathNotEmployedStatus));

                    ListOptionsSelect(lstNotEmployedStatus, varEmploymentStatus);
                }
            }
            else
            {

                Console.WriteLine("Employment Status is not selected");
            }

            

        }

        [Given(@"the User Annual Income is (.*)")]
        public void GivenTheUserAnnualIncomeIs(string p0)
        {
            string strAnnualIncome = p0;
            if (strAnnualIncome != "")
            { 

            string strXpathAnnualIncomeSalary = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Salary or wages per year (before tax)']//div[@class='control-cell']/div[@type='currency']/div[1]/div//input[@type='text']";
            IWebElement varAnnualIncomeSalary = myChromeDriver.FindElementByXPath(strXpathAnnualIncomeSalary);
            varAnnualIncomeSalary.SendKeys(p0);
            }
            else
            {

                Console.WriteLine("Annual Income Not Applicable");
            }
        }

        [Given(@"the User KiwiSaver Member Contribution is (.*)")]
        public void GivenTheUserKiwiSaverMemberContributionIs(string p0)
        {
            string strKiwiSaverMemberContribution = p0;
            if (strKiwiSaverMemberContribution != "")
            {
                string varRiskProfile = p0;

                switch (varRiskProfile)
                {
                    case "3%":
                        string strXpathKiwiSaverMemberContributeThreePercent = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='KiwiSaver member contribution']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='3']//label[@class='well-label']/span[@class='input-label']/span[@class='ng-scope']";
                        IWebElement varContributeThreePercent = myChromeDriver.FindElementByXPath(strXpathKiwiSaverMemberContributeThreePercent);
                        varContributeThreePercent.Click();
                        break;

                    case "4%":
                        string strXpathKiwiSaverMemberContributeFourPercent = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']/div[@class='inner-cell']//div[@label='KiwiSaver member contribution']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='4']//label[@class='well-label']";
                        IWebElement varContributeFourPercent = myChromeDriver.FindElementByXPath(strXpathKiwiSaverMemberContributeFourPercent);
                        varContributeFourPercent.Click();
                        break;

                    case "6%":
                        string strXpathKiwiSaverMemberContributeSixPercent = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']/div[@class='inner-cell']//div[@label='KiwiSaver member contribution']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='6']//label[@class='well-label']";
                        IWebElement varContributeSixPercent = myChromeDriver.FindElementByXPath(strXpathKiwiSaverMemberContributeSixPercent);
                        varContributeSixPercent.Click();
                        break;

                    case "8%":
                        string strXpathKiwiSaverMemberContributeEightPercent = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']/div[@class='inner-cell']//div[@label='KiwiSaver member contribution']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='8']//label[@class='well-label']";
                        IWebElement varContributeEightPercent = myChromeDriver.FindElementByXPath(strXpathKiwiSaverMemberContributeEightPercent);
                        varContributeEightPercent.Click();
                        break;

                    case "10%":
                        string strXpathKiwiSaverMemberContributeTenPercent = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='KiwiSaver member contribution']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='10']//label[@class='well-label']/span[@class='input-label']/span[@class='ng-scope']";
                        IWebElement varContributeTenPercent = myChromeDriver.FindElementByXPath(strXpathKiwiSaverMemberContributeTenPercent);
                        varContributeTenPercent.Click();
                        break;

                }
            }
            else
            {
                Console.WriteLine("KiwiSaver Member Contribution is not applicable");
            }



        }

        [Given(@"the User Current Kiwi Saver Balance is (.*)")]
        public void GivenTheUserCurrentKiwiSaverBalanceIs(string p0)
        {
            string strCurrentKiwiSaverBalance = p0;
            if (strCurrentKiwiSaverBalance != "")
            {
                string strXpathCurrentKiwiSaverBalance = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Current KiwiSaver balance']//div[@class='control-cell']/div[@type='currency']/div[1]/div//input[@type='text']";
                IWebElement varCurrentKiwiSaverBalance = myChromeDriver.FindElementByXPath(strXpathCurrentKiwiSaverBalance);
                varCurrentKiwiSaverBalance.SendKeys(p0);
            }
            else
            {
                Console.WriteLine("Current KiwiSaver Balance is optional");
            }

        }

        [Given(@"the User Voluntary Contributions is (.*)")]
        public void GivenTheUserVoluntaryContributionsIs(string p0)
        {
            string strVoluntaryContributions = p0;
            if (strVoluntaryContributions != "")
            {
                string strXpathVoluntaryContributions = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Voluntary contributions']//div[@class='control-cell']/div[@type='currency']/div[@class='control-group']/div[1]//input[@type='text']";
                IWebElement varVoluntaryContributions = myChromeDriver.FindElementByXPath(strXpathVoluntaryContributions);
                varVoluntaryContributions.SendKeys(p0);
            }
            else
            {
                Console.WriteLine("Voluntary Contributions is optional");
            }
        }

        [Given(@"the User Voluntary Contributions Frequency is (.*)")]
        public void GivenTheUserVoluntaryContributionsFrequencyIs(string p0)
        {

            string strVoluntaryContributionsFrequency = p0;
            if (strVoluntaryContributionsFrequency != "")
            {
                String strVoluntaryContributeFrequencyOption = p0;
                Console.WriteLine(strVoluntaryContributeFrequencyOption);
                string strXpathVoluntaryContributeFrequency = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']//div[@label='Voluntary contributions']//div[@class='control-cell']/div[@type='currency']/div[@class='control-group']/div[2]/div/div[@class='control-well']/div";
                IWebElement varVoluntaryContributeFrequency = myChromeDriver.FindElementByXPath(strXpathVoluntaryContributeFrequency);
                varVoluntaryContributeFrequency.Click();
                IWebElement varVoluntaryContributeFrequencySelect = myChromeDriver.FindElementByXPath(strXpathVoluntaryContributeFrequency);


                if (strVoluntaryContributeFrequencyOption is "Weekly")
                {

                    string strXpathVoluntaryContrFreqWeek = "//html[@id='ng-app']//div[@id='widget']//div[@label='Voluntary contributions']//div[@class='control-cell']/div[@type='currency']/div[@class='control-group']/div[2]/div/div[@class='dropdown']/ul[@class='option-list']/li[@value='week']/div[@class='label']";
                    IList<IWebElement> lstVoluntaryContrFreqWeek = varVoluntaryContributeFrequencySelect.FindElements(By.XPath(strXpathVoluntaryContrFreqWeek));

                    ListOptionsSelect(lstVoluntaryContrFreqWeek, strVoluntaryContributeFrequencyOption);

                }
                else if (strVoluntaryContributeFrequencyOption is "Fortnightly")
                {

                    string strXpathVoluntaryContrFreqFortnight = "//html[@id='ng-app']//div[@id='widget']//div[@label='Voluntary contributions']//div[@class='control-cell']/div[@type='currency']/div[@class='control-group']/div[2]/div/div[@class='dropdown']/ul[@class='option-list']/li[@value='fortnight']//span[@class='ng-binding ng-scope']";
                    IList<IWebElement> lstVoluntaryContrFreqFortnight = varVoluntaryContributeFrequencySelect.FindElements(By.XPath(strXpathVoluntaryContrFreqFortnight));

                    ListOptionsSelect(lstVoluntaryContrFreqFortnight, strVoluntaryContributeFrequencyOption);
                }
                else if (strVoluntaryContributeFrequencyOption is "Monthly")
                {

                    string strXpathVoluntaryContrFreqMonth = "//html[@id='ng-app']//div[@id='widget']//div[@label='Voluntary contributions']//div[@class='control-cell']/div[@type='currency']/div[@class='control-group']/div[2]/div/div[@class='dropdown']/ul[@class='option-list']/li[@value='month']/div[@class='label']";
                    IList<IWebElement> lstVoluntaryContrFreqMonth = varVoluntaryContributeFrequencySelect.FindElements(By.XPath(strXpathVoluntaryContrFreqMonth));

                    ListOptionsSelect(lstVoluntaryContrFreqMonth, strVoluntaryContributeFrequencyOption);
                }

                else if (strVoluntaryContributeFrequencyOption is "Annually")
                {

                    string strXpathVoluntaryContrFreqYear = "//html[@id='ng-app']//div[@id='widget']//div[@label='Voluntary contributions']//div[@class='control-cell']/div[@type='currency']/div[@class='control-group']/div[2]/div/div[@class='dropdown']/ul[@class='option-list']/li[@value='year']/div[@class='label']";
                    IList<IWebElement> lstVoluntaryContrFreqYear = varVoluntaryContributeFrequencySelect.FindElements(By.XPath(strXpathVoluntaryContrFreqYear));

                    ListOptionsSelect(lstVoluntaryContrFreqYear, strVoluntaryContributeFrequencyOption);
                }

                else
                {
                    Console.WriteLine("Voluntary Contributions Frequency is not applicable");
                }

            }
            else
            {
                Console.WriteLine("Voluntary Contributions Frequency is not applicable");
            }

  
        }

        [Given(@"the User Risk Profile is (.*)")]
        public void GivenTheUserRiskProfileIs(string p0)
        {
            string strRiskProfiles = p0;
            if (strRiskProfiles != "")
            {
                string strRiskProfile = p0;

                switch (strRiskProfile)
                {
                    case "Defensive":
                        string strXpathRiskProfileDefensiveOption = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']/div[@class='inner-cell']//div[@label='Risk profile']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='low']//label[@class='well-label']";
                        IWebElement varDefensiveOption = myChromeDriver.FindElementByXPath(strXpathRiskProfileDefensiveOption);
                        varDefensiveOption.Click();
                        break;

                    case "Conservative":
                        string strXpathRiskProfileConservativeOption = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Risk profile']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='medium']//label[@class='well-label']/span[@class='input-label']/span[@class='ng-scope']";
                        IWebElement varDConservativeOption = myChromeDriver.FindElementByXPath(strXpathRiskProfileConservativeOption);
                        varDConservativeOption.Click();
                        break;

                    case "Balanced":
                        string strXpathRiskProfileBalancedOption = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']/div[@class='inner-cell']//div[@label='Risk profile']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='high']//label[@class='well-label']";
                        IWebElement varBalancedOption = myChromeDriver.FindElementByXPath(strXpathRiskProfileBalancedOption);
                        varBalancedOption.Click();
                        break;

                    case "Growth":
                        string strXpathRiskProfileGrowthOption = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']/div[@class='inner-cell']//div[@label='Risk profile']//div[@class='control-cell']/div//div[@class='control-group']/div[@value='growth']//label[@class='well-label']";
                        IWebElement varGrowthOption = myChromeDriver.FindElementByXPath(strXpathRiskProfileGrowthOption);
                        varGrowthOption.Click();
                        break;

                }

            }
            else
            {
                Console.WriteLine("Risk Profile is not selected");
            }
   
        }

        [Given(@"the User Savings Goal is (.*)")]
        public void GivenTheUserSavingsGoalIs(string p0)
        {
            string strSavingsGoal = p0;
            if (strSavingsGoal != "")
            {
                string strXpathSavingsGoal = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@label='Savings goal at retirement']//div[@class='control-cell']/div[@type='currency']/div[1]/div//input[@type='text']";
                IWebElement varSavingsGoal = myChromeDriver.FindElementByXPath(strXpathSavingsGoal);
                varSavingsGoal.SendKeys(p0);
            }
            else
            {
                Console.WriteLine("Savings Goals is optional");
            }

        }

        [When(@"the User KiwiSaver projected balance is calculated")]
        public void WhenTheUserKiwiSaverProjectedBalanceIsCalculated()
        {
            string strXpathKiwiSaverCalculate = "//html[@id='ng-app']//div[@id='widget']//div[@class='widget-body']/div[@class='inner-cell']/div[2]/button/span[@class='label']";
            IWebElement varKiwiSaverCalculate = myChromeDriver.FindElementByXPath(strXpathKiwiSaverCalculate);
            varKiwiSaverCalculate.Click();

        }

        [Then(@"the User can see the estimated KiwiSaver Projected Balance")]
        public void ThenTheUserCanSeeTheEstimatedKiwiSaverProjectedBalance()
        {
            
            string strEstimatedAmount = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@class='field-group-set results-field-group-set']//div[@class='results-heading']/span[2]";
            var varEstimatedAmount = myChromeDriver.FindElementByXPath(strEstimatedAmount).Text;
            
            string strProjectedWeeklyAmount = "//html[@id='ng-app']//div[@id='widget']/div[@class='widget-stage']/div[@class='widget-body']//div[@class='field-group-set results-field-group-set']//div[@class='result-label-group']/div[1]/span[@class='projected-weekly-amount']";
            var varProjectedWeeklyAmount = myChromeDriver.FindElementByXPath(strProjectedWeeklyAmount).Text;

            Console.WriteLine("At age 65, your KiwiSaver balance is estimated to be: " + varEstimatedAmount);
            Console.WriteLine("This works out to be "  + varProjectedWeeklyAmount + " per week based on a life expectancy of 90, and does not include your New Zealand Superannuation entitlements");

            Assert.IsTrue(varEstimatedAmount != "", " At age 65, your KiwiSaver balance is estimated to be: ");
            Assert.IsTrue(varProjectedWeeklyAmount != "", " per week based on a life expectancy of 90, and does not include your New Zealand Superannuation entitlements ");

            myChromeDriver.SwitchTo().DefaultContent();
            myChromeDriver.Dispose();
        }

        public void ListOptionsSelect(IList<IWebElement> WPKSDropDownList, String strDropDownOption)
        {
                int WPKSListCount = WPKSDropDownList.Count;

                for (int i = 0; i< WPKSListCount; i++)
                {
                    if (WPKSDropDownList[i].Text == strDropDownOption)
                    {
                    WPKSDropDownList[i].Click();
                    }
                }
                Console.WriteLine(WPKSDropDownList);
        }


    }
}
