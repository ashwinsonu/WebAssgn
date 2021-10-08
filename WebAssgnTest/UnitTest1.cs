using NUnit.Framework;
using WebAssgn.AssignModel;
namespace WebAssgnTest
{
    public class Tests
    {

        public Logintbl lt;
        
        [SetUp]
        public void Setup()
        {
            
            lt = new Logintbl();
            
        }

        [Test]
        public void TestLogin()
        {
            

            string actualres = lt.Username;
           string expectedres = "name";
            string actualres1 = lt.Password;
            string expectedres1 = "pass";
            Assert.AreEqual(expectedres, actualres);
            Assert.AreEqual(expectedres1, actualres1);
        }

    }
}