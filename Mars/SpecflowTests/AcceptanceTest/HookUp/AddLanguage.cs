using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SpecFlowFeature1Steps : Utils.Start
    {
        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();


        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {

            // call the profile page language class
            SpecflowPages.Utils.ProfilePageLang.AddLang();

        }

   
        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Utils.ProfilePageLang.ValidateLang();
        }
          



 }
}
