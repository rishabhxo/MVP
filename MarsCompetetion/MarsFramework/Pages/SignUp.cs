using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    class SignUp
    {
        /*  public SignUp()
          {
              PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
          }

          #region  Initialize Web Elements 
          //Finding the Join 
          [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
          private IWebElement Join { get; set; }

          //Identify FirstName Textbox
          [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[1]/input")]
          private IWebElement FirstName { get; set; }

          //Identify LastName Textbox
          [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[2]/input")]
          private IWebElement LastName { get; set; }

          //Identify Email Textbox
          [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[3]/input")]
          private IWebElement Email { get; set; }

          //Identify Password Textbox
          [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[4]/input")]
          private IWebElement Password { get; set; }

          //Identify Confirm Password Textbox
          [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[5]/input")]
          private IWebElement ConfirmPassword { get; set; }

          //Identify Term and Conditions Checkbox
          [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[6]/div/div/input")]
          private IWebElement Checkbox { get; set; }

          //Identify join button
          [FindsBy(How = How.XPath, Using = "//*[@id='submit-btn']")]
          private IWebElement JoinBtn { get; set; }
          #endregion
          */
        private RemoteWebDriver _driver;
        public SignUp(RemoteWebDriver driver) => _driver = driver;

        #region  Initialize Web Elements
        //Finding the Join 
        private IWebElement BtnJoinSubmit => _driver.FindElementByXPath("//*[@id='home']/div/div/div[1]/div/button");

        //Identify FirstName Textbox
        private IWebElement TxtBoxFirstName => _driver.FindElementByXPath("//input[@placeholder='First name']");

        //Identify LastName Textbox
        private IWebElement TxtBoxLastName => _driver.FindElementByXPath("//input[@placeholder='Last name']");

        //Identify Email Textbox
        private IWebElement TxtBoxEmail => _driver.FindElementByXPath("//input[contains(@name,'email')]");

        //Identify Password Textbox
        private IWebElement TxtBoxPassword => _driver.FindElementByXPath("//input[contains(@name,'password')]");

        //Identify Confirm Password Textbox
        private IWebElement TxtBoxConfirmPassword => _driver.FindElementByXPath("//input[contains(@name,'confirmPassword')]");

        //Identify Term and Conditions Checkbox
        private IWebElement ChkBoxTick => _driver.FindElementByXPath("//input[@type='checkbox']");

        //Identify join button
        private IWebElement BtnJoinSumbit => _driver.FindElementByXPath("//*[@id='submit-btn']");
        #endregion
        #region SignUp 

        internal void Register()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignUp");
            //Click on Join button
            BtnJoinSubmit.Click();

            //Enter FirstName
            TxtBoxFirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));

            //Enter LastName
            TxtBoxLastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            TxtBoxEmail.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter Password
            TxtBoxPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            TxtBoxConfirmPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on Checkbox
            ChkBoxTick.Click();

            //Click on join button to Sign Up
            BtnJoinSubmit.Click();


        }
        #endregion
    }
}
