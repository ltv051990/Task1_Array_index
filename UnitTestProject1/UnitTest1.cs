using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace UnitTestProject1
{
    [TestClass]
    public class ParseInputUnitTest
    {
        [TestMethod]
        public void EmtyInput()
        {
            //arrange
            string input = string.Empty;
            bool expected = false;

            //act
            var parseInput = new ParseInput();
            parseInput.Start(input);

            //assert
            Assert.AreEqual(expected, parseInput.IsValid);
        }


        [TestMethod]
        public void NegativeInput()
        {
            //arrange
            string input = "-1";
            bool expected = false;

            //act
            var parseInput = new ParseInput();
            parseInput.Start(input);

            //assert
            Assert.AreEqual(expected, parseInput.IsValid);
        }


        [TestMethod]
        public void NullReferenceInput()
        {
            //arrange
            string input = null;
            bool expected = false;

            //act
            var parseInput = new ParseInput();
            parseInput.Start(input);

            //assert
            Assert.AreEqual(expected, parseInput.IsValid);
        }


        [TestMethod]
        public void OverflowInput()
        {
            //arrange
            string input = "12345678945613456";
            bool expected = false;

            //act
            var parseInput = new ParseInput();
            parseInput.Start(input);

            //assert
            Assert.AreEqual(expected, parseInput.IsValid);
        }


        [TestMethod]
        public void CorrectInput()
        {
            //arrange
            string input = "6";
            bool expected = true;

            //act
            var parseInput = new ParseInput();
            parseInput.Start(input);

            //assert
            Assert.AreEqual(expected, parseInput.IsValid);
        }


        [TestMethod]
        public void CorrectZeroInput()
        {
            //arrange
            string input = "0";
            bool expected = true;

            //act
            var parseInput = new ParseInput();
            parseInput.Start(input);

            //assert
            Assert.AreEqual(expected, parseInput.IsValid);
        }

    }


    [TestClass]
    public class LogicUnitTest
    {
        [TestMethod]
        public void InputSixTest()
        {
            //arrange
            int input = 6;
            long expected = 24;

            //act
            var mainLogic = new Logic();
            long res = mainLogic.Result(input);
            
            //assert
            Assert.AreEqual(expected, res);
        }


        [TestMethod]
        public void InputZeroTest()
        {
            //arrange
            int input = 0;
            long expected = 1;

            //act
            var mainLogic = new Logic();
            long res = mainLogic.Result(input);
            
            //assert
            Assert.AreEqual(expected, res);
        }



        [TestMethod]
        public void InputOneTest()
        {
            //arrange
            int input = 1;
            long expected = 1;

            //act
            var mainLogic = new Logic();
            long res = mainLogic.Result(input);

            //assert
            Assert.AreEqual(expected, res);
        }

    }
}
