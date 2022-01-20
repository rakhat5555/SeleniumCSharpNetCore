using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCoreC
{
    internal class Day1ClassBasic
    {
        public class Tests
        {

            //Hooks in NUnit
            [SetUp]
            public void Setup()
            {


            }

            [Test]
            public void Test1()
            {
                Console.WriteLine("Hi from day1 class");
                Console.Read();
        }
    }
}
}
