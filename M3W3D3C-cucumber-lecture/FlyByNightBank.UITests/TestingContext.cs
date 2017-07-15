using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.UITests
{
    public class TestingContext
    {
        public IWebDriver Driver { get; set; }

        public TestingContext()
        {
            if(this.Driver == null)
            {
                this.Driver = new ChromeDriver();
            }
        }
    }
}
