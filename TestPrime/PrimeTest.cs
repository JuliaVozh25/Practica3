using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestPrime
{
    public class PrimeTest
    {
        [Test]
        public void Test_3()
        {
            Assert.That(Проверка_числа_на_простоту.Program.IsPrimeNumber(3), Is.EqualTo(true));
        }
        [Test]
        public void Test_6()
        {
            Assert.That(Проверка_числа_на_простоту.Program.IsPrimeNumber(6), Is.EqualTo(false));
        }
    }
}
