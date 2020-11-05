using NUnit.Framework;
using System;
using RestSharp;
using System.Linq;
using System.Net;
using System.Collections;

namespace Wordpress
{
    class StatusCode : Base
    {
        
        public void GetResponse(string link)
        {          
            RestClient client = new RestClient(link);
            RestRequest request = new RestRequest(Method.GET);
            client.FollowRedirects = false;
            IRestResponse response = client.Execute(request);
            try
            {
                Assert.That((int)response.StatusCode, Is.EqualTo(200));
            }
            catch (Exception)
            {
                if (response.StatusCode.Equals(HttpStatusCode.MovedPermanently) || response.StatusCode.Equals(HttpStatusCode.Found) || response.StatusCode.Equals(HttpStatusCode.TemporaryRedirect))
                {
                    string redirectlink = response.Headers.Where(x => x.Name == "Location").Select(y => y.Value).FirstOrDefault().ToString();
                    Console.WriteLine(link + "  " + (int)response.StatusCode + " to " + redirectlink);
                }
            }
            finally
            {
                if ((response.StatusCode != HttpStatusCode.OK) && (response.StatusCode != HttpStatusCode.MovedPermanently) && (response.StatusCode != HttpStatusCode.Found) && (response.StatusCode != HttpStatusCode.TemporaryRedirect))
                {
                    Console.WriteLine(link + "  " + (int)response.StatusCode);
                }
            }
        }
    }
}


    


    
