﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace AreaTriangleTest
{
    public class Class1
    {
        [Test]
        public void Test1()
        {
         Assert.That(Triangle.AreaTriangle.rightTriangle(12,7,15), Is.EqualTo(42));
        }
    }
}
