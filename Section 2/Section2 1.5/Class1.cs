﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;



namespace Section2_1._5
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void BasicAssertions()
        {
            int total = 100, marks1 = 60, marks2 = 75;
            string name = null;

            Assert.That(marks1, Is.Not.EqualTo(marks2));
            Assert.That(marks1, Is.LessThan(marks2));
            Assert.That(marks2, Is.InRange(50, 75));

            Assert.That(name, Is.Null);
        }
    }
}
