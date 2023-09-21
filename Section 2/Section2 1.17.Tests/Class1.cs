using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Section2_1._17;


namespace Section2_1._17.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void StaticFake()
        {
            int x = 10, y = 20;
            var wrapper = new SCalcWrapper();
            Assert.That(wrapper.add(x, y), Is.EqualTo(x + y));
        }

    }

}
