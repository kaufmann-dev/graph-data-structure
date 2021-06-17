using System;
using graph.core;
using NUnit.Framework;

namespace graph.unittest
{
    public class EnumTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, (int)EStations.SPITTELAU);
            Assert.AreEqual(1, (int)EStations.FRIEDENSBRÜCKE);
            
            Assert.AreEqual(4,Enum.GetValues(typeof(EStations)).Length);
            
            Assert.Pass();
        }
    }
}