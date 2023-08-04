using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumLearning
{
    public class Tests:DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Mango");
            CustomControl.Click(Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            CustomControl.SelectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");
            Console.WriteLine("Test1");
            Assert.Pass();
        }


    }
}