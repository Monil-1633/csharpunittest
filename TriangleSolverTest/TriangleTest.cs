/*Monil Patel
Student ID:- 8775412
Assignment - 2*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTest
{
    [TestFixture]
    public class TriangleTest1
    {
        [Test]

        public void ValidEquilateral_Input60And60And60_OutputValidEquilateral()
        {
            Triangle eq = new Triangle();

            int firstSideOfeq = 60;
            int secondSideOfeq = 60;
            int thirdSideOfeq = 60;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            string actual = eq.AnalyzeTriangle(firstSideOfeq, secondSideOfeq, thirdSideOfeq);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsosceles_Input4And4And5_OutputValidIsosceles1()
        {
            Triangle iso1 = new Triangle();

            int firstSideOfiso1 = 4;
            int secondSideOfiso1 = 4;
            int thirdSideOfiso1 = 5;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual = iso1.AnalyzeTriangle(firstSideOfiso1, secondSideOfiso1, thirdSideOfiso1);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void ValidIsosceles_Input4And3And3_OutputValidIsosceles2()
        {
            Triangle iso2 = new Triangle();

            int firstSideOfiso2 = 4;
            int secondSideOfiso2 = 3;
            int thirdSideOfiso2 = 3;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual = iso2.AnalyzeTriangle(firstSideOfiso2, secondSideOfiso2, thirdSideOfiso2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsosceles_Input5And4And5_OutputValidIsosceles2()
        {
            Triangle iso3 = new Triangle();

            int firstSideOfiso3 = 5;
            int secondSideOfiso3 = 4;
            int thirdSideOfiso3 = 5;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            string actual = iso3.AnalyzeTriangle(firstSideOfiso3, secondSideOfiso3, thirdSideOfiso3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScalene_Input4And5And6_OutputValidScalene1()
        {
            Triangle sca1 = new Triangle();

            int firstSideOfsca1 = 4;
            int secondSideOfsca1 = 5;
            int thirdSideOfsca1 = 6;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = sca1.AnalyzeTriangle(firstSideOfsca1, secondSideOfsca1, thirdSideOfsca1);

            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void ValidScalene_Input2And3And4_OuputValidScalene2()
        {
            Triangle sca2 = new Triangle();

            int firstSideOfsca2 = 2;
            int secondSideOfsca2 = 3;
            int thirdSideOfsca2 = 4;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = sca2.AnalyzeTriangle(firstSideOfsca2, secondSideOfsca2, thirdSideOfsca2);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void ValidScalene_Input6And8And10_OuputValidScalene3()
        {
            Triangle sca3 = new Triangle();

            int firstSideOfsca3 = 6;
            int secondSideOfsca3 = 8;
            int thirdSideOfsca3 = 10;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = sca3.AnalyzeTriangle(firstSideOfsca3, secondSideOfsca3, thirdSideOfsca3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScalene_Input9And12And15_OuputValidScalene4()
        {
            Triangle sca4 = new Triangle();

            int firstSideOfsca4 = 9;
            int secondSideOfsca4 = 12;
            int thirdSideOfsca4 = 15;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = sca4.AnalyzeTriangle(firstSideOfsca4, secondSideOfsca4, thirdSideOfsca4);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidScalene_Input5And7And9_OuputValidScalene5()
        {
            Triangle sca5 = new Triangle();

            int firstSideOfsca5 = 5;
            int secondSideOfsca5 = 7;
            int thirdSideOfsca5 = 9;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = sca5.AnalyzeTriangle(firstSideOfsca5, secondSideOfsca5, thirdSideOfsca5);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void ZeroLengthSide_Input4And0And5_OutputInValid1()
        {
            Triangle zero1 = new Triangle();

            int firstSideOfZero1 = 4;
            int secondSideOfZero1 = 0;
            int thirdSideOfZero1 = 5;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = zero1.AnalyzeTriangle(firstSideOfZero1, secondSideOfZero1, thirdSideOfZero1);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void ZeroLengthSide_Input0And0And5_OutputInValid2()
        {
            Triangle zero2 = new Triangle();

            int firstSideOfZero2 = 0;
            int secondSideOfZero2 = 0;
            int thirdSideOfZero2 = 5;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = zero2.AnalyzeTriangle(firstSideOfZero2, secondSideOfZero2, thirdSideOfZero2);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void ZeroLengthSide_Input0And0And0_OutputInValid3()
        {
            Triangle zero3 = new Triangle();

            int firstSideOfZero3 = 0;
            int secondSideOfZero3 = 0;
            int thirdSideOfZero3 = 0;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = zero3.AnalyzeTriangle(firstSideOfZero3, secondSideOfZero3, thirdSideOfZero3);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void InvalidResponse_InputNegative1AndNegative2AndNegative3_OutputInValid1()
        {
            Triangle invalid1 = new Triangle();

            int firstSideOfInvalid1 = -1;
            int secondSideOfInvalid1 = -2;
            int thirdSideOfInvalid1 = -3;

            string expected = "Based on the values entered, the triangle is INVALID";
            string actual = invalid1.AnalyzeTriangle(firstSideOfInvalid1, secondSideOfInvalid1, thirdSideOfInvalid1);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void InvalidResponse_InputNegative1And2AndNegative3_OutputInValid2()
        {
            Triangle invalid2 = new Triangle();

            int firstSideOfInvalid2 = -1;
            int secondSideOfInvalid2 = 2;
            int thirdSideOfInvalid2 = -3;

            string expected = "Based on the values entered, the triangle is INVALID";
            string actual = invalid2.AnalyzeTriangle(firstSideOfInvalid2, secondSideOfInvalid2, thirdSideOfInvalid2);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void InvalidResponse_InputNegative4And5And10_OutputInValid3()
        {
            Triangle invalid3 = new Triangle();

            int firstSideOfInvalid3 = -4;
            int secondSideOfInvalid3 = 5;
            int thirdSideOfInvalid3 = 10;

            string expected = "Based on the values entered, the triangle is INVALID";
            string actual = invalid3.AnalyzeTriangle(firstSideOfInvalid3, secondSideOfInvalid3, thirdSideOfInvalid3);

            Assert.AreEqual(expected, actual);

        }





    }
}
