/*
 * Author : Schito Dylan, Sutter Antoine
 * Date : 01.10.2018
 * File : OperatorsTests.cs
 * Description : Test methods of Operator's class
 */
 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperatorsPuzzle222_6.Tests
{
    [TestClass()]
    public class OperatorTests
    {
        [TestMethod()]
        public void ExecuteTest()
        {
            // Arrange
            Operator target = new Operator("Bonsoir", 12, (a, b) => a + 666 + b);

            // Act
            int actualResult = target.Execute(5999, 1);
            // Assert
            Assert.AreEqual(6666, actualResult);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            Operator target = new Operator("Ceci est un test", 12, (a, b) => a + b);

            // Act
            string actualResult = target.ToString();

            // Assert
            Assert.AreEqual("Ceci est un test", actualResult);
        }
    }
}