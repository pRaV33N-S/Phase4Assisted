﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;


namespace Section2_1._9.Tests
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void Exceptions()
        {
            var calc = new Calculator();

            Assert.Throws<InvalidOperationException>(() => calc.addStrings("aaa", "Bbb"));
        }


    }

}
