// 	File Name : Authorization.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 05-05-2020
//
using System;
using RestSharp;
using MicrosoftCAPS.Utils;
using Newtonsoft.Json.Linq;

namespace MicrosoftCAPS.Endpoints
{
    public class Authentication
    {
        public static string CloudAuthentication()
        {
            IRestResponse response = MakeRequest.GetResponse(Variables.BASE_URL + Variables.EXTENSION);
            var responseObject = response.Content;

            var dataContent = JObject.Parse(responseObject);
            //var dataArray = JArray.Parse(responseObject)["data"];
            foreach (var data in dataContent["data"])
            {
                var user = (string)data["user"]["userName"];
                return user;
            }

            return null;
        }
    }
}
