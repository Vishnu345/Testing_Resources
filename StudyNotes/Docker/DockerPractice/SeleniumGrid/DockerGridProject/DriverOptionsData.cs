using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerGridProject
{
    public class DriverOptionsData
    {
        public static IEnumerable<TestCaseData> GetDriverOptionsData()
        {
            yield return new TestCaseData(new ChromeOptions());
            yield return new TestCaseData(new FirefoxOptions());
        }
    }
}
