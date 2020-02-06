using NUnit.Framework;
using RadoslawKarbowiakLabZadanie3.Classes.SQLAdapter;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void CheckDatabase()
        {
            SQLConnector sQLConnector = new SQLConnector();


        }
    }
}