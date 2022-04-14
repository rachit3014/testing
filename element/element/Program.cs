using OpenQA.Selenium;
//using OpenQA.Selenium.IJavaScriptExecutor;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace element
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("test case started ");
           // IWebDriver Driver = new ChromeDriver();

           // IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

           // Thread.Sleep(2000);

           //// Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

           // Driver.Manage().Window.Maximize();
           // Thread.Sleep(2000);
           // string name = "Rachit Kumar";
           // string email = "rachitkumar3014@gmail.com";
           // string Caddress = "koderma";
           // string Paddress = "patna";

           // Thread.Sleep(2000);
           // Driver.FindElement(By.Id("userName")).SendKeys(name);
           // Thread.Sleep(2000);
           // Driver.FindElement(By.Id("userEmail")).SendKeys(email);
           // Thread.Sleep(2000);
           // Driver.FindElement(By.Id("currentAddress")).SendKeys(Caddress);
           // Thread.Sleep(2000);
           // Driver.FindElement(By.Id("permanentAddress")).SendKeys(Paddress);

           // Thread.Sleep(2000);
           // js.ExecuteScript("window.scrollBy(0,500)");
           // Thread.Sleep(2000);

           // Driver.FindElement(By.Id("submit")).Click();
           // Task.Delay(2000).Wait();

           // Console.WriteLine("test case ended");

           
           // Driver.Close();
           //Driver.Quit();
             

            IWebDriver Driver = new ChromeDriver();
            //  Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            //string Fname = "Rachit";
            //string Lname = "Kumar";
            //string email = "rachitkumar3014@gmail.com";
            //string name = "8797982028";
            //string DOB = "16 Dec 2000";
            //string Subjects = "";
            //string hob = "listeinig Music";
            //string cadd="koderma";
            //string Padd = "Patna";
            //Driver.FindElement(By.Id("firstName")).SendKeys("rachit");
            //Driver.FindElement(By.Id("lastName")).SendKeys("Kumar");
            //Driver.FindElement(By.Id("userEmail")).SendKeys("rachitkumar3014@gmail.com");
            //Thread.Sleep(2000);
            //Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();
            //Driver.FindElement(By.Id("userNumber")).SendKeys("8797982028");
            ////Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("16 Feb 2000");
            //Driver.FindElement(By.Id("subjectsContainer")).SendKeys("Computer");
            //Driver.FindElement(By.Id("hobbies-checkbox-1")).Click();
            //Driver.FindElement(By.Id("currentAddress")).SendKeys("Koderma");
            //Driver.FindElement(By.Id("state")).SendKeys("Jharkhand");

            //Driver.FindElement(By.Id("city")).SendKeys("Koderma");

            /// radio button

            // Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            // Driver.Manage().Window.Maximize();
            // Thread.Sleep(2000);
            //// Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---yes
            // //Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---impressive
            // Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[1].Click();//--no


            // check box

            //Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            //Driver.Manage().Window.Maximize();

            //Thread.Sleep(2000);

            // Driver.FindElement(By.XPath("//span[contains(@class,'rct-checkbox')]")).Click();
            //Thread.Sleep(2000);
            //Driver.Close();

            //Driver.Quit()




            // Buttons
            //Driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
        
          //Driver.FindElement(By.Id("rightClickBtn")).Click();
            //web tables




            //Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("addNewRecordButton")).Click();
            //Driver.FindElement(By.Id("firstName")).SendKeys("rachit");
            //Driver.FindElement(By.Id("lastName")).SendKeys("kumar");
            //Driver.FindElement(By.Id("userEmail")).SendKeys("ygyg@gmail.com");
            //Driver.FindElement(By.Id("age")).SendKeys("20");
            //Driver.FindElement(By.Id("salary")).SendKeys("2000000011");
            //Driver.FindElement(By.Id("department")).SendKeys("IT");
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("submit")).Click();

            //Thread.Sleep(2000);
            //Driver.Quit();
            //Driver.Close();
           

            //link Table

            Driver.Navigate().GoToUrl("https://demoqa.com/links");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Id("simpleLink")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("dynamicLink")).Click();
            Driver.Quit();  
          
            Thread.Sleep(2000);
            Driver.Quit();

            // Driver.Dispose();
            Thread.Sleep(2000);




            



            
        }
    }
}
