using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2_1._8_Tests
{
    [TestFixture]
    public class Class1
    {


        [Test]
        public void MultipleAssertions()
        {
            int total = 100, marks1 = 60, marks2 = 75;
            string name = null;

            Assert.Multiple(() =>
            {
                Assert.That(marks1, Is.Not.EqualTo(marks2));
                Assert.That(marks1, Is.LessThan(marks2));
                Assert.That(marks2, Is.InRange(50, 75));
            });

        }


    }

}
