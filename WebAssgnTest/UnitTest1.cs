using NUnit.Framework;
using WebAssgn.AssignModel;
using System.Net.Http;
using System.Configuration;
using System.Net;     
using System.Net.Http.Headers;
using WebAssgn.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebAssgnTest
{
   
    public class Tests
    {
        public Chaat c;
        public MenuController mc;
        public Logintbl lt;
        
        [SetUp]
        public void Setup()
        {
            c = new Chaat();
            mc = new MenuController();
            lt = new Logintbl();
            
        }
        [Test]
        public void ValidGetTest()
        {


            var res = mc.Getchaats().Result as OkObjectResult;
            Assert.AreEqual(200, res.StatusCode);
        }
        [Test]
        public void InValidGetTest()
        {
           
           
            var res = mc.Getchaats().Result as OkObjectResult;
            Assert.AreEqual(500, res.StatusCode);
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