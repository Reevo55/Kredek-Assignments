using RadoslawKarbowiakLabZadanie3.Classes.SQLAdapter;
using System;
using Xunit;

namespace RadoslawKarbowiakLab3Zad.XTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SQLConnector sQLConnector = new SQLConnector();

            bool success = sQLConnector.SignInDTD("Test", "tester");

            Assert.True(success);
        }
    }
}
