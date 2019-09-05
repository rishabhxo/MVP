using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    [TestFixture(BrowserType.Firefox)]
    [TestFixture(BrowserType.Chrome)]
    public class Program : Base
    {
        public Program(BrowserType browser) : base(browser)
        {
        }

        [Test]
        public void ShareSkill()
        {
            // Create Share Skills object to call methods      
            ShareSkill obj = new ShareSkill(_driver);
            //call methods
            obj.EnterShareSkill();
            obj.ValidateAddedSkill("Testing");
        }

        [Test]
        public void ManageList()
        {
            // Create ManageListing Object to call menthods
            ManageListings obj = new ManageListings(_driver);
            //call method
            obj.DeleteService("Testing");
           

        }




    }
}