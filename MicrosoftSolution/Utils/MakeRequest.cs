// 	File Name : MakeRequest.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 05-05-2020
//
using System;
using RestSharp;

namespace MicrosoftCAPS.Utils
{
    public class MakeRequest
    {
        public static IRestResponse GetResponse(string url)
        {
            try
            {
                var client = new RestClient(url)
                {
                    UserAgent = ".Net Request by Developer"
                };
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", $"Token {Variables.TOKEN}");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful.Equals(true))
                {
                    return response;
                }
                return null;
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
    }
}
