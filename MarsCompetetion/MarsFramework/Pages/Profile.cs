﻿using MarsFramework.Global;
using MarsFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using static MarsFramework.Global.GlobalDefinitions;
using static NUnit.Core.NUnitFramework;

namespace MarsFramework
{
    internal class Profile
    {

        /* public Profile()
         {
             PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
         }

         #region  Initialize Web Elements 
         //Click on Edit button
         [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Part Time')]//i[@class='right floated outline small write icon']")]
         private IWebElement AvailabilityTimeEdit { get; set; }

         //Click on Availability Time dropdown
         [FindsBy(How = How.Name, Using = "availabiltyType")]
         private IWebElement AvailabilityTime { get; set; }

         //Click on Availability Time option
         [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
         private IWebElement AvailabilityTimeOpt { get; set; }

         //Click on Availability Hour dropdown
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[3]/div")]
         private IWebElement AvailabilityHours { get; set; }

         //Click on salary
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[4]/div")]
         private IWebElement Salary { get; set; }

         //Click on Location
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
         private IWebElement Location { get; set; }

         //Choose Location
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
         private IWebElement LocationOpt { get; set; }

         //Click on City
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
         private IWebElement City { get; set; }

         //Choose City
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
         private IWebElement CityOpt { get; set; }

         //Click on Add new to add new Language
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
         private IWebElement AddNewLangBtn { get; set; }

         //Enter the Language on text box
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
         private IWebElement AddLangText { get; set; }

         //Enter the Language on text box
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
         private IWebElement ChooseLang { get; set; }

         //Enter the Language on text box
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
         private IWebElement ChooseLangOpt { get; set; }

         //Add Language
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
         private IWebElement AddLang { get; set; }

         //Click on Add new to add new skill
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
         private IWebElement AddNewSkillBtn { get; set; }

         //Enter the Skill on text box
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
         private IWebElement AddSkillText { get; set; }

         //Click on skill level dropdown
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
         private IWebElement ChooseSkill { get; set; }

         //Choose the skill level option
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
         private IWebElement ChooseSkilllevel { get; set; }

         //Add Skill
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
         private IWebElement AddSkill { get; set; }

         //Click on Add new to Educaiton
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
         private IWebElement AddNewEducation { get; set; }

         //Enter university in the text box
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
         private IWebElement EnterUniversity { get; set; }

         //Choose the country
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
         private IWebElement ChooseCountry { get; set; }

         //Choose the skill level option
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
         private IWebElement ChooseCountryOpt { get; set; }

         //Click on Title dropdown
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
         private IWebElement ChooseTitle { get; set; }

         //Choose title
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
         private IWebElement ChooseTitleOpt { get; set; }

         //Degree
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
         private IWebElement Degree { get; set; }

         //Year of graduation
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
         private IWebElement DegreeYear { get; set; }

         //Choose Year
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
         private IWebElement DegreeYearOpt { get; set; }

         //Click on Add
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
         private IWebElement AddEdu { get; set; }

         //Add new Certificate
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
         private IWebElement AddNewCerti { get; set; }

         //Enter Certification Name
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
         private IWebElement EnterCerti { get; set; }

         //Certified from
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
         private IWebElement CertiFrom { get; set; }

         //Year
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
         private IWebElement CertiYear { get; set; }

         //Choose Opt from Year
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
         private IWebElement CertiYearOpt { get; set; }

         //Add Ceritification
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
         private IWebElement AddCerti { get; set; }

         //Add Desctiption
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
         private IWebElement Description { get; set; }

         //Click on Save Button
         [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
         private IWebElement Save { get; set; }

         #endregion
         */
        private RemoteWebDriver _driver;
        public Profile(RemoteWebDriver driver) => _driver = driver;

        #region  Initialize Web Elements 

        //Click on Profile button
        private IWebElement TbProfile => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));

        //Click on Add new to add new Language
        private IWebElement BtnAddNewLang => _driver.FindElement(By.XPath("//div[contains(text(),'Add New')]"));

        //Enter the Language on text box
        private IWebElement TxtAddLang => _driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

        //EChoose Languge Level Box
        private IWebElement DdlChooseLang => _driver.FindElement(By.XPath("//select[@name='level']"));

        //Enter the Language on text box      
        private IWebElement DdlChooseLangOpt => _driver.FindElement(By.XPath("//option[@value]"));

        //Add Language      
        private IWebElement AddLang => _driver.FindElement(By.XPath("//input[@class='ui teal button']"));

        //ShareSkill Tab
        private IWebElement BtnShareSkill => _driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));

        //ManageListing Tab
        private IWebElement TbManangeList => _driver.FindElement(By.XPath("//a[contains(.,'Manage Listings')]"));

        #endregion

        internal void AddLanguage(string Languages, string Level)
        {
            //Click on Profile tab 
            TbProfile.Click();
            BtnAddNewLang.Click();
            TxtAddLang.SendKeys(Languages);
            DdlChooseLang.Click();
            IList<IWebElement> LanguagesLevel = DdlChooseLangOpt.FindElements(By.XPath("//select[@name='level']//option[@value]"));
            int count = LanguagesLevel.Count;
            for (int i = 0; i < count; i++)
            {
                if (LanguagesLevel[i].Text == Level)
                {
                    LanguagesLevel[i].Click();
                    break;
                }

            }
            AddLang.Click();


        }
        //Validate Added Language
        internal void ValidateLanguage()
        {

            try
            {
                //Start the Reports
                Base.test = Base.extent.StartTest("Add Language Test");
                String expectedValue = "Hindi";
                string actualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                //Check if expected value is equal to actual value
                if (expectedValue == actualValue)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(_driver, "LanguageAdded");
                    //Assertion
                    Assert.AreEqual(actualValue, expectedValue);
                }

                else
                    Base.test.Log(LogStatus.Fail, "Add Test Failed");

            }


            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Add Language Test Failed", e.Message);
            }

        }
    }
}