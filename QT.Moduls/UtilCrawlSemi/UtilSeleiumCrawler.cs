using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.UtilSelenium
{
    public class UtilSeleiumCrawler
    {
        public static IWebElement FindElement(IWebElement driver, By by)
        {
            try
            {
                return driver.FindElement(by);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static ReadOnlyCollection<IWebElement> FindElements(IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElements(by);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal static string GetAttribute(IWebElement itemTab, string filed)
        {
            try
            {
                return itemTab.GetAttribute(filed).ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }



        public static ReadOnlyCollection<IWebElement> FindElements(IWebElement item, By by)
        {

            try
            {
                return item.FindElements(by);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static IWebElement FindElement (IWebDriver driverLocal, By by)
        {
            try
            {
                return driverLocal.FindElement(by);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        
    }
}
