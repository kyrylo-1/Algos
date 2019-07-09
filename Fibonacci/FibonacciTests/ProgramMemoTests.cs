using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Tests
{
    [TestClass()]
    public class ProgramMemoTests
    {
        [TestMethod()]
        public void FibMemoTest()
        {
            Assert.AreEqual(8, new ProgramMemo().FibMemo(6));
        }
    }
}