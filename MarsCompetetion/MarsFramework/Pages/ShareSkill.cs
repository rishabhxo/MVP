using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using MarsFramework.Global;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using System.Threading;
using RelevantCodes.ExtentReports;
using System.Collections.Generic;
using static MarsFramework.Global.GlobalDefinitions;


namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        private RemoteWebDriver _driver;
        public ShareSkill(RemoteWebDriver driver) => _driver = driver;

        #region Initialize Web Elements 

        // ShareSkills button
        IWebElement TbShareSkill => _driver.FindElementByXPath("//a[@class='ui basic green button']");

        // Title
        IWebElement TxtBoxTitle => _driver.FindElementByName("title");

        // Description
        IWebElement TxtBoxDescription => _driver.FindElementByName("description");

        // Select Category
        IWebElement DdlCategory => _driver.FindElementByName("categoryId");


        //Select SubCategory 
        IWebElement DdlSubCategory => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) > select.ui.fluid.dropdown");


        //Select Tag Names
        IWebElement TxtBoxTag => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField");

        //Select Service Type -Hourly Basis
        IWebElement RdoServiceTypeHourly => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        //Select Service Type -One-off
        IWebElement RdoServiceTypeOnOff => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");
        //Select Location Type - Onsite

        //Select Location Type - Onsite
        IWebElement RdoLocationTypeOnsite => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        //Select Location Type - Onsite
        IWebElement RdoLocationTypeOnline => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)");

        //Avilable Days -Start Date
        IWebElement DtpStartDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)");

        //Avilable Days -End Date
        IWebElement DtpEndDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)");

        //Skill Trade - Skill Exchange
        IWebElement RdoSkillExchange => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        // Skill Exchange - Required Skills
        IWebElement TxtBoxRequiredSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField");

        //Skill Trade - Credit
        IWebElement RdoCredit => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)");


        //Credit - Enter Amount
        private IWebElement TxtBoxCreditAmount => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)");

        // Status Active 
        private IWebElement RdoStatusActive => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        // Status Hidden 
        IWebElement RdoStatusHidden => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)");

        // Work Sample 
        IWebElement FilWorkSample => _driver.FindElementByCssSelector("//*[@id='selectFile']");

        // Save Share Skills
        IWebElement BtnSaveShareSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)");

        // Cancel Share Skills
        IWebElement BtnCancelShareSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)");

        #endregion

        internal void EnterShareSkill()
        {
            #region Navigate to Share Skills Page

            // Wait for Skill Tab 
            _ = Extension.WaitForElementClickable(TbShareSkill, _driver, 60);
            // Click on Share Skills Page
            TbShareSkill.Click();
            //Populate the excel data            
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills");

            #endregion


            #region Enter Title 

            //Enter the data in Title textbox
            TxtBoxTitle.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "title"));

            #endregion

            #region Enter Description

            //Enter the data in Description textbox
            TxtBoxDescription.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EnterDescription"));


            #endregion

            #region Category Drop Down

            // Click on Category Dropdown
            _ = Extension.WaitForElementClickable(DdlCategory, _driver, 60);
            DdlCategory.Click();

            // Select Category from Category Drop Down
            var ddlCategory = new SelectElement(DdlCategory);
            ddlCategory.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "category")));

            // Click on Sub-Category Dropdown
            DdlSubCategory.Click();

            //Select Sub-Category from the Drop Down
            var ddlSubCategory = new SelectElement(DdlSubCategory);
            ddlSubCategory.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "subcategory")));
            #endregion

            #region Tags
            // Eneter Tag
            TxtBoxTag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "TagName"));
            TxtBoxTag.SendKeys(Keys.Enter);

            #endregion

            #region Service Type Selection

            // Service Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                RdoServiceTypeHourly.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One-off service")
            {
                RdoServiceTypeOnOff.Click();
            }
            #endregion

            #region Select Location Type
            // Location Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "On-site")
            {
                RdoLocationTypeOnsite.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "Online")
            {
                RdoLocationTypeOnline.Click();
            }
            #endregion

            #region Select Available Dates from Calendar
            // Select Start Date

            string sdate = GlobalDefinitions.ExcelLib.ReadData(2, "Start-Date");
            DtpStartDate.SendKeys(Keys.Backspace);
            string format = "dd/MM/yyyy";
            string newStartDate = DateTime.Parse(sdate).ToString(format);
            DtpStartDate.SendKeys(newStartDate);



            #region Select Skill Trade
            // Select Skill Trade

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Skill-exchange")
            {

                RdoSkillExchange.Click();
                TxtBoxRequiredSkills.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ExchangeSkill"));
                TxtBoxRequiredSkills.SendKeys(Keys.Enter);

            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Credit")
            {

                RdoCredit.Click();
                Thread.Sleep(1000);
                TxtBoxCreditAmount.SendKeys(ExcelLib.ReadData(2, "AmountInExchange"));
                TxtBoxCreditAmount.SendKeys(Keys.Enter);
            }
            #endregion

            #region Select User Status
            // Select User Status

            if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Active")
            {
                RdoStatusActive.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Hidden")
            {
                RdoStatusHidden.Click();
            }
            #endregion





            #region Save / Cancel Skill
            // Save or Cancel New Skill

            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Save")
            {
                BtnSaveShareSkills.Click();
                Thread.Sleep(1000);

            }
            else if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Cancel")
            {
                BtnCancelShareSkills.Click();
            }

            #endregion

        }


        internal void ValidateAddedSkill(string title)
        {
            try
            {
                //Go to Manage Listing Tab
                _driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]")).Click();
                IWebElement GridNextPageLink = _driver.FindElement(By.XPath("//button[contains(.,'>')]"));
                bool loop = true;
                IList<IWebElement> tblSkillList = _driver.FindElements(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr"));
                if (tblSkillList.Count > 0)
                {
                    Base.test = Base.extent.StartTest("Share Skill Test");
                    //Get the row count in table
                    var skillRowCount = tblSkillList.Count;
                    while (loop)
                    {
                        for (int i = 1; i <= skillRowCount; i++)
                        {
                            //Get the row value from ServiceList table
                            IWebElement ShareTitle = _driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[3]"));

                            if (ShareTitle.Text == title)
                            {
                                Base.test.Log(LogStatus.Pass, "Test Pass,Share Skill Successfull");
                                SaveScreenShotClass.SaveScreenshot(_driver, "ServiceAdded");
                                ///Assertion
                                Assert.AreEqual(title, ShareTitle.Text);
                                loop = false;
                                return;

                            }
                        }
                        //Click next page
                        GridNextPageLink.Click();
                    }
                }
            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Share Skill Unsuccessful" + e.Message);
            }
        }

    }
}
#endregion