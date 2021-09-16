using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonAutomation
{
    public class Tests:Base.BaseClass
    {
        //Used to test the tile after launcing the browser
        [Test, Order(0)]
        public void TestMethodTitleAfterLaunching()
        {
            WebPagesActions.SignInActions.TitleAfterLaunching(driver);
        }

        //Used to read the data from excel
        //Used to sign up into Amazon with credentials given in the excel
        [Test, Order(1)]
        public void TestMethodForSignupIntoAmazon()
        {
            WebPagesActions.RegistrationAction.ReadDataFromExcel(driver);
            WebPagesActions.RegistrationAction.SignupIntoAmazon(driver);
        }

        //Used to read the data from excel
        //Used to login into Amazon with credentials given in the excel
        [Test, Order(2)]
        public void TestMethodForLoginIntoAmazon()
        {
            WebPagesActions.SignInActions.ReadDataFromExcel(driver);
            WebPagesActions.SignInActions.LoginIntoAmazon(driver);
        }

    }
}