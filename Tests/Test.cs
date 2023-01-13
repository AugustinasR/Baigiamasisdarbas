using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Test
    {
        [Test]
        public void TestMethod()
        {
            Driver.CreateDriver();
            Driver.OpenPage("https://www.google.com/");
        }
    }
}
