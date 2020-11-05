using NUnit.Framework;
using RestSharp;
using System.Net;
using System;
using System.Linq;

namespace Wordpress
{
    [TestFixture]
    class Redirects
    {
        [TestCase("http://tradeallcrypto.com/")]
        [TestCase("https://www.tradeallcrypto.com/")]
        [TestCase("http://www.tradeallcrypto.com/")]
        [TestCase("https://tradeallcrypto.com/index.html")]
        [TestCase("https://tradeallcrypto.com/index.php")]
        [TestCase("https://tradeallcrypto.com/amp/")]
        [TestCase("https://tradeallcrypto.com/?amp/")]       
        public void GetStatus(string address)
        {
            {
                RestClient client = new RestClient(address);
                RestRequest request = new RestRequest(Method.GET);
                client.FollowRedirects = false;
                IRestResponse response = client.Execute(request);
                if (response.StatusCode.Equals(HttpStatusCode.MovedPermanently))
                {
                    RestClient secondclient = new RestClient(address);
                    RestRequest secondrequest = new RestRequest(Method.GET);
                    secondclient.FollowRedirects = true;
                    IRestResponse secondresponse = secondclient.Execute(secondrequest);
                    string redirectlink = secondresponse.ResponseUri.ToString();
                    Console.WriteLine(redirectlink);
                    Assert.AreEqual("https://tradeallcrypto.com/", redirectlink);
                }
                else
                {
                    Assert.That((int)response.StatusCode, Is.EqualTo(301));
                }
            }
        }
    }
}
    




 


