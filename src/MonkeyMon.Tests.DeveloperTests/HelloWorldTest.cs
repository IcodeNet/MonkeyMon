using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MonkeyMon.Tests.DeveloperTests
{
    [TestFixture]
    public class HelloWorldTest
    {
        [TestCase]
        public void DoHelloWorldTest()
        {
            Thread.Sleep(20);
            Thread.Sleep(20);
            Thread.Sleep(20);
        }
    }
}
