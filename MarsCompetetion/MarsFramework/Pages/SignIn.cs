using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class SignIn
    {
        private RemoteWebDriver _driver;
        public SignIn(RemoteWebDriver driver) => _driver = driver;
        
        #region  Initialize Web Elements 

        //Finding the Sign Link
        private IWebElement TbSignIn => _driver.FindElementByXPath("//*[@id='home']/div/div/div[1]/div/a");

        // Finding the Email Field
        private IWebElement TxtBoxEmail => _driver.FindElementByXPath("//input[@name='email']");

        //Finding the Password Field
        private IWebElement TxtBoxPassword => _driver.FindElementByXPath("//input[@name='password']");

        //Finding the Login Button
        IWebElement BtnLogin => _driver.FindElementByXPath("//button[contains(.,'Login')]");

        #endregion

        internal void LoginSteps()
        {
            //extent Reports
            Base.test = Base.extent.StartTest("Login Test");

            //Populate the Excel sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            _driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            //Click on Sign In tab
            TbSignIn.Click();
            //Enter the data in Username textbox
            TxtBoxEmail.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            //Enter the password 
            TxtBoxPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Click on Login button
            BtnLogin.Click();

            if (_driver.WaitForElementDisplayed(By.XPath("//a[contains(text(),'Mars Logo')]"), 1000))
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");
            }
            else
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login failed");
            }

        }
    }
}