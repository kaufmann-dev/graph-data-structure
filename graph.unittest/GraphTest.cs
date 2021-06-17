using System;
using graph.core;
using NUnit.Framework;

namespace graph.unittest
{
    public class GraphTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddEdge()
        {
            Graph<EStations, TubeData> vTube = new Graph<EStations, TubeData>();
            
            vTube.AddEdge(EStations.SPITTELAU, EStations.FRIEDENSBRÜCKE, new TubeData("hallo"));
            vTube.AddEdge(EStations.FRIEDENSBRÜCKE, EStations.ROSSAULAENDE, new TubeData("Welt"));
            vTube.AddEdge(EStations.SCHOTTENRING, EStations.ROSSAULAENDE, new TubeData("Welt"));
            
            Assert.IsTrue(vTube.HasEdge(EStations.SPITTELAU, EStations.FRIEDENSBRÜCKE));
            Assert.IsTrue(vTube.HasEdge(EStations.FRIEDENSBRÜCKE, EStations.ROSSAULAENDE));
            Assert.IsTrue(vTube.HasEdge(EStations.SCHOTTENRING, EStations.ROSSAULAENDE));
            Assert.IsFalse(vTube.HasEdge(EStations.FRIEDENSBRÜCKE, EStations.FRIEDENSBRÜCKE));
            
            Assert.Pass();
        }
    }
}