using Newtonsoft.Json.Linq;
using NUnit.Framework;
using NUnitTestProject1.Tests;
using RestSharp;
using System.Linq;
using System.Net;

namespace FinalTask.APITests
{
    public class APITests : ApiTestFixture
    {
        public string userId { get; set; }
        public string id { get; set; }


        [Test]
        public void GetMethod()
        {
            Initialize();
            Request = new RestRequest("users/1", Method.GET);
            Response = Client.Get(Request);
            Assert.That(Response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            ResponseJson = JObject.Parse(Response.Content);
            string name = (string)ResponseJson.SelectTokens("name").FirstOrDefault();
            Assert.AreEqual("Leanne Graham", name);
        }

        [Test]
        public void PostMethod()
        {
            Initialize();
            Request = new RestRequest("/posts", Method.POST);
            Request.AddHeader("Content-type", "application/json");
            Request.AddJsonBody(
                  new
              {
                      userId= "1",
                      id= "1"
                  });
            Response = Client.Post(Request);
            Assert.That(Response.StatusCode, Is.EqualTo(HttpStatusCode.Created));

        }

        [Test]
        public void DeleteMethod()
        {
            Initialize();
            Request = new RestRequest("users/1", Method.DELETE);
            Response = Client.Delete(Request);
            Assert.That(Response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
