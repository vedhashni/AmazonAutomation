using OpenQA.Selenium;
using AmazonAutomation.WebPagesData;

namespace AmazonAutomation.WebPagesActions
{
    public class RegistrationAction
    {
        public static ExcelOperation excel;
        public static Signup register;

        //Here we are reading the data from excel
        public static void ReadDataFromExcel(IWebDriver driver)
        {
            excel = new ExcelOperation();
            excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\AmazonAutomation\AmazonAutomation\WebPagesData\SignupData.xlsx");
        }

        //Used for implementing signup operations
        public static void SignupIntoAmazon(IWebDriver driver)
        {
            excel = new ExcelOperation();
            register = new Signup(driver);
            register.signup.Click();
            System.Threading.Thread.Sleep(1000);
            //By invoking the readdate method values in table is retrived
            register.name.SendKeys(excel.ReadData(1, "Name"));
            //is used to wait in a particular page before taking another action
            System.Threading.Thread.Sleep(3000);
            //By invoking the readdate method values in table is retrived
            register.mobilenumber.SendKeys(excel.ReadData(1, "MobileNumber"));
            //is used to wait in a particular page before taking another action
            System.Threading.Thread.Sleep(3000);
            //By invoking the readdate method values in table is retrived
            register.email.SendKeys(excel.ReadData(1, "Email"));
            //is used to wait in a particular page before taking another action
            System.Threading.Thread.Sleep(3000);
            //By invoking the readdate method values in table is retrived
            register.password.SendKeys(excel.ReadData(1, "Password"));
            //is used to wait in a particular page before taking another action
            System.Threading.Thread.Sleep(3000);
            register.continuebtn.Click();
            System.Threading.Thread.Sleep(70000);
            register.newaccountbtn.Click();
            System.Threading.Thread.Sleep(10000);
        }
    }
}
