using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lesson8
{
   
        class MyTest
        {

            [Test]
            public void AreaCTest()
            {
                Circle circle = new Circle();

                
                double expectedValue = 12.56;
                double actualValue = circle.AreaC();
                Assert.AreEqual(expectedValue,  actualValue);

            }
            [Test]
            public void AreaTTest()
            {
                Triangle triangle = new Triangle();
                double a = 1;
                double b = 2;
                double c = 3;

                double expectedValue = 4;
                double actualValue = triangle.AreaT(a, b, c);
                Assert.AreEqual(expectedValue, actualValue);

            }
        }


    }
}
