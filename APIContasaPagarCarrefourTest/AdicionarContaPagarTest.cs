
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Text;


namespace APIContasaPagarCarrefourTest;
[TestClass]
public class AdicionarContaPagarTest
{
    private static IWebDriver? driver;
    private StringBuilder? verificationErrors;
    private bool acceptNextAlert = true;
    [ClassCleanup]
    public static void CleanupClass()
    {
        try
        {
            //driver.Quit();// quit does not close the window
            driver.Close();
            driver.Dispose();
        }
        catch (Exception)
        {
            // Ignore errors if unable to close the browser
        }
    }

    [TestInitialize]
    public void InitializeTest()
    {
        verificationErrors = new StringBuilder();
    }

    [TestCleanup]
    public void CleanupTest()
    {
        Assert.AreEqual("", verificationErrors.ToString());
    }

    [TestMethod]
    public void TheUntitledTestCaseTest()
    {
        driver.Navigate().GoToUrl("https://localhost:7276/swagger/index.html");
        driver.FindElement(By.Id("operations-tag-Home")).Click();
        driver.FindElement(By.XPath("//div[@id='model-ContaPagar']/span[2]/button/span/span/span")).Click();
        driver.FindElement(By.XPath("//div[@id='swagger-ui']/section/div[2]/div[2]/div[4]/section/section/h4/button/span")).Click();
        driver.FindElement(By.XPath("//div[@id='swagger-ui']/section/div[2]/div[2]/div[4]/section/section/h4/button/span")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-get_Home_ObterContasPagar']/div/button/span[2]/a/span")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-get_Home_ObterContasPagar']/div[2]/div/div/div/div[2]/button")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-get_Home_ObterContasPagar']/div[2]/div/div[2]/button")).Click();
        driver.FindElement(By.XPath("//div[@id='CRAz6EM=']/div/div/pre/code/span[20]")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-post_Home_ObterConsolidadoDiario']/div/button/span[2]/a/span")).Click();
        driver.FindElement(By.XPath("//input[@value='']")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-post_Home_ObterConsolidadoDiario']/div[2]/div/div/div/div[2]/button")).Click();
        driver.FindElement(By.XPath("//input[@value='']")).Click();
        driver.FindElement(By.XPath("//input[@value='2023-06']")).Clear();
        driver.FindElement(By.XPath("//input[@value='2023-06']")).SendKeys("2023-06");
        driver.FindElement(By.XPath("//div[@id='swagger-ui']/section/div[2]/div[2]/div[3]")).Click();
        driver.FindElement(By.XPath("//input[@value='2023-06']")).Click();
        driver.FindElement(By.XPath("//input[@value='2023-05-06']")).Clear();
        driver.FindElement(By.XPath("//input[@value='2023-05-06']")).SendKeys("2023-05-06");
        driver.FindElement(By.XPath("//div[@id='operations-Home-post_Home_ObterConsolidadoDiario']/div[2]/div/div[2]/button")).Click();
        driver.Close();
        driver.FindElement(By.XPath("//div[@id='operations-Home-get_Home_ObterContasPagar']/div/button")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-get_Home_ObterContasPagar']/div[2]/div/div/div/div[2]/button")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-get_Home_ObterContasPagar']/div[2]/div/div[2]/button")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-post_Home_ObterConsolidadoDiario']/div/button/span[2]/a/span")).Click();
        driver.FindElement(By.XPath("//div[@id='operations-Home-post_Home_ObterConsolidadoDiario']/div[2]/div/div/div/div[2]/button")).Click();
        driver.FindElement(By.XPath("//input[@value='']")).Click();
        driver.FindElement(By.XPath("//input[@value='2023-06-15']")).Clear();
        driver.FindElement(By.XPath("//input[@value='2023-06-15']")).SendKeys("2023-06-15");
        driver.FindElement(By.XPath("//div[@id='operations-Home-post_Home_ObterConsolidadoDiario']/div[2]/div/div[2]/button")).Click();
        driver.FindElement(By.XPath("//input[@value='2023-06-15']")).Click();
        driver.FindElement(By.XPath("//input[@value='2023-05-15']")).Clear();
        driver.FindElement(By.XPath("//input[@value='2023-05-15']")).SendKeys("2023-05-15");
        driver.FindElement(By.XPath("//div[@id='operations-Home-post_Home_ObterConsolidadoDiario']/div[2]/div/div[2]/button")).Click();
    }
    private bool IsElementPresent(By by)
    {
        try
        {
            driver.FindElement(by);
            return true;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    private bool IsAlertPresent()
    {
        try
        {
            driver.SwitchTo().Alert();
            return true;
        }
        catch (NoAlertPresentException)
        {
            return false;
        }
    }

    private string CloseAlertAndGetItsText()
    {
        try
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            if (acceptNextAlert)
            {
                alert.Accept();
            }
            else
            {
                alert.Dismiss();
            }
            return alertText;
        }
        finally
        {
            acceptNextAlert = true;
        }
    }
}

    
    
    
    
    
    
    //private IWebDriver driver;

    //[TestInitialize]
    //public void Setup()
    //{
    //    driver = new ChromeDriver();
    //}
    //[TestMethod]
    //public void AdicionarContaPagar()
    //{
    //    // Navegar para a página de adicionar conta a pagar
    //    driver.Navigate().GoToUrl("https://localhost:7276/Home/AdicionarContaPagar?dateVencimento=2023-05-15&datePagamento=2023-05-15&fornecedor=Filcus&valor=15000&pago=true");

    //    // Verificar se o título da página é o esperado
    //    Assert.AreEqual("Adicionar Conta a Pagar", driver.Title);

    //    // Realizar outras verificações ou interações na página
    //    // ...

    //    // Fechar o navegador
    //    driver.Quit();
    //}
    //[TestCleanup]
    //public void Cleanup()
    //{
    //    driver.Dispose();
    //}

//}