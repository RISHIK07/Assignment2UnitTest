using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2UnitTest;

namespace Assignment02.Tests
{
    class RectangleTest
    {
        [TestFixture]
        public class Test1
        {
            [Test]

            public void TestLength()
            {
                //Arrange
                int length = 7;
                int width = 9;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 7;

                //Act
                int actual = rectangle.GetLength();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestLength1()
            {
                //Arrange
                int length = 21;
                int width = 25;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 21;

                //Act
                int actual = rectangle.GetLength();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestLength2()
            {
                //Arrange
                int length = 9;
                int width = 3;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 9;

                //Act
                int actual = rectangle.GetLength();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestSetLength()
            {
                //Arrange
                int length = 31;
                int width = 51;

                Rectangle rec = new Rectangle(length, width);

                int need = 21;

                //Act
                int actual = rec.SetLength(21);

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestSetLength1()
            {
                //Arrange
                int length = 3;
                int width = 13;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 23;

                //Act
                int actual = rectangle.SetLength(23);

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestSetLength2()
            {
                //Arrange
                int length = 555;
                int width = 333;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 66;

                //Act
                int actual = rectangle.SetLength(66);

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestWidth()
            {
                //Arrange
                int length = 4;
                int width = 15;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 15;

                //Act
                int actual = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestWidth1()
            {
                //Arrange
                int length = 32;
                int width = 35;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 35;

                //Act
                int actual = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestWidth2()
            {
                //Arrange
                int length = 127;
                int width = 178;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 178;

                //Act
                int actual = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestSetWidth()
            {
                //Arrange
                int length = 19;
                int width = 6;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 30;

                //Act
                int actual = rectangle.SetWidth(30);

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestSetWidth1()
            {
                //Arrange
                int length = 53;
                int width = 23;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 55;

                //Act
                int actual = rectangle.SetWidth(55);

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestSetWidth2()
            {
                //Arrange
                int length = 712;
                int width = 851;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 234;

                //Act
                int actual = rectangle.SetWidth(234);

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestPerimeter()
            {
                //Arrange
                int length = 4;
                int width = 7;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 22;

                //Act
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestPerimeter1()
            {
                //Arrange
                int length = 34;
                int width = 56;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 180;

                //Act
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestPerimeter2()
            {
                //Arrange
                int length = 13;
                int width = 2;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 30;

                //Act
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestArea()
            {
                //Arrange
                int length = 24;
                int width = 1;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 24;

                //Act
                int actual = rectangle.GetArea();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestArea1()
            {
                //Arrange
                int length = 2;
                int width = 22;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 44;

                //Act
                int actual = rectangle.GetArea();

                //Assert
                Assert.AreEqual(need, actual);
            }
            [Test]
            public void TestArea2()
            {
                //Arrange
                int length = 24;
                int width = 2;

                Rectangle rectangle = new Rectangle(length, width);

                int need = 48;

                //Act
                int actual = rectangle.GetArea();

                //Assert
                Assert.AreEqual(need, actual);
            }
        }
    }
}
