using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays.src
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestOddIntegers()
        {
            Assert.AreEqual((int)Math.Pow(500, 2), Arrays.GetOddIntegers().Sum(), "The sum of all odd numbers seems to be incorrect");
            Assert.AreEqual(500, Arrays.GetOddIntegers().Count(), "The count of all odd numbers seems to be incorrect");
        }

        [Test]
        public void TestFizzBuzz()
        {
            Assert.AreEqual(234168, Arrays.GetFizzBuzz().Sum(), "The sum of all FizzBuzz numbers seems to be incorrect");
            Assert.AreEqual(467, Arrays.GetFizzBuzz().Count(), "The count of all FizzBuzz numbers seems to be incorrect");
        }

        [Test]
        public void Test100to200()
        {
            Assert.AreEqual(15150, Arrays.Get100to200().Sum(), "The sum of the numbers 100 to 200 seems to be incorrect");
            Assert.AreEqual(101, Arrays.Get100to200().Count(), "The count of the numbers 100 to 200 seems to be incorrect");
        }

        [Test]
        public void Test2D()
        {
            object tArray = Arrays.Get2D();
            if (typeof(int[][]) == tArray.GetType())
            {
                var array = tArray as int[][];
                Assert.DoesNotThrow(() => array[9][9] = 0);
                Assert.AreEqual(100, array.SelectMany(x => x).Count(), "The total count of items was not the expected amount");
            }
            else 
            {
                Assert.IsInstanceOf(typeof(int[,]), tArray, "The type of the array was neither of the expected types");

                var array = tArray as int[,];
                Assert.DoesNotThrow(() => array[9, 9] = 0);
                Assert.AreEqual(100, array.Length, "The total count of items was not the expected amount");
            }
        }
    }
}
