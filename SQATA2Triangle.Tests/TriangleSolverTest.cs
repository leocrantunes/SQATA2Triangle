using NUnit.Framework;

namespace SQATA2Triangle.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        /// <summary>
        /// Test identifier: 1.1
        /// Test description: tests triangle solver analyze
        /// Method of execution: Automated
        /// Triangle values: 1, 1, 1
        /// Values chosen because they are the minimum value 
        /// for each side for a equilateral triangle
        /// Expected output: EQUILATERAL
        /// </summary>
        [Test]
        public void TestAnalyze_Input_1_1_1_Output_EQUILATERAL()
        {
            // 1. Arrange
            int firstValue = 1;
            int secondValue = 1;
            int thirdValue = 1;
            string expResult = TriangleSolver.EQUILATERAL;

            // 2. Act
            string result = TriangleSolver.Analyze(firstValue, secondValue, thirdValue);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        /// <summary>
        /// Test identifier: 1.2
        /// Test description: tests triangle solver analyze
        /// Method of execution: Automated
        /// Triangle values: int.MaxValue, int.MaxValue, int.MaxValue
        /// Values chosen because they are the maximum value 
        /// for each side for an equilateral triangle
        /// Expected output: EQUILATERAL
        /// </summary>
        [Test]
        public void TestAnalyze_Input_MAX_MAX_MAX_Output_EQUILATERAL()
        {
            // 1. Arrange
            int firstValue = int.MaxValue;
            int secondValue = int.MaxValue;
            int thirdValue = int.MaxValue;
            string expResult = TriangleSolver.EQUILATERAL;

            // 2. Act
            string result = TriangleSolver.Analyze(firstValue, secondValue, thirdValue);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        /// <summary>
        /// Test identifier: 1.3
        /// Test description: tests triangle solver analyze
        /// Method of execution: Automated
        /// Triangle values: 1, 2, 2
        /// Values chosen because they are the minimum value 
        /// for each side for an isosceles triangle
        /// Expected output: ISOSCELES
        /// </summary>
        [Test]
        public void TestAnalyze_Input_1_2_2_Output_ISOSCELES()
        {
            // 1. Arrange
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 2;
            string expResult = TriangleSolver.ISOSCELES;

            // 2. Act
            string result = TriangleSolver.Analyze(firstValue, secondValue, thirdValue);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        /// <summary>
        /// Test identifier: 1.4
        /// Test description: tests triangle solver analyze
        /// Method of execution: Automated
        /// Triangle values: int.MaxValue-1, int.MaxValue, int.MaxValue
        /// Values chosen because they are the maximum value 
        /// for each side for an isosceles triangle
        /// Expected output: ISOSCELES
        /// </summary>
        [Test]
        public void TestAnalyze_Input_MAXM1_MAX_MAX_Output_ISOSCELES()
        {
            // 1. Arrange
            int firstValue = int.MaxValue - 1;
            int secondValue = int.MaxValue;
            int thirdValue = int.MaxValue;
            string expResult = TriangleSolver.ISOSCELES;

            // 2. Act
            string result = TriangleSolver.Analyze(firstValue, secondValue, thirdValue);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        /// <summary>
        /// Test identifier: 1.5
        /// Test description: tests triangle solver analyze
        /// Method of execution: Automated
        /// Triangle values: 2, 3, 4
        /// Values chosen because they are the minimum value 
        /// for each side for a scalene triangle
        /// Expected output: SCALENE
        /// </summary>
        [Test]
        public void TestAnalyze_Input_2_3_4_Output_SCALENE()
        {
            // 1. Arrange
            int firstValue = 2;
            int secondValue = 3;
            int thirdValue = 4;
            string expResult = TriangleSolver.SCALENE;

            // 2. Act
            string result = TriangleSolver.Analyze(firstValue, secondValue, thirdValue);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        /// <summary>
        /// Test identifier: 1.6
        /// Test description: tests triangle solver analyze
        /// Method of execution: Automated
        /// Triangle values: int.MaxValue-2, int.MaxValue-1, int.MaxValue
        /// Values chosen because they are the maximum value for each side for a scalene triangle
        /// Expected output: SCALENE
        /// </summary>
        [Test]
        public void TestAnalyze_Input_MAXM2_MAXM1_MAX_Output_SCALENE()
        {
            // 1. Arrange
            int firstValue = int.MaxValue - 2;
            int secondValue = int.MaxValue - 1;
            int thirdValue = int.MaxValue;
            string expResult = TriangleSolver.SCALENE;

            // 2. Act
            string result = TriangleSolver.Analyze(firstValue, secondValue, thirdValue);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        /// <summary>
        /// Test identifier: 1.7
        /// Test description: tests triangle solver analyze
        /// Method of execution: Automated
        /// Triangle values: 1, 1, 2
        /// Values chosen because they are the minimum values
        /// for an invalid triangle and they do not build an isosceles triangle
        /// Expected output: NOT_TRIANGLE
        /// </summary>
        [Test]
        public void TestAnalyze_Input_1_1_2_Output_NOT_TRIANGLE()
        {
            // 1. Arrange
            int firstValue = 1;
            int secondValue = 1;
            int thirdValue = 2;
            string expResult = TriangleSolver.NOT_TRIANGLE;

            // 2. Act
            string result = TriangleSolver.Analyze(firstValue, secondValue, thirdValue);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }

        /// <summary>
        /// Test identifier: 1.8
        /// Test description: tests triangle solver analyze
        /// Method of execution: Automated
        /// Triangle values: 1, 2, 3
        /// Values chosen because they are the second set of minimum values 
        /// for an invalid triangle and they do not build a scalene triangle
        /// Expected output: NOT_TRIANGLE
        /// </summary>
        [Test]
        public void TestAnalyze_Input_1_2_3_Output_NOT_TRIANGLE()
        {
            // 1. Arrange
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            string expResult = TriangleSolver.NOT_TRIANGLE;

            // 2. Act
            string result = TriangleSolver.Analyze(firstValue, secondValue, thirdValue);

            // 3. Assert
            Assert.AreEqual(expResult, result);
        }
    }
}