
using System.Collections.Generic;
using System.Diagnostics;
using TBAAPI.V3Client.NetStandard.Api;
using TBAAPI.V3Client.NetStandard.Client;
using TBAAPI.V3Client.NetStandard.Model;

namespace pirec.TBA
{
    public static class TbaApi
    {
        public static void TestApi()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://www.thebluealliance.com/api/v3";
            // Configure API key authorization: apiKey
            config.ApiKey.Add("X-TBA-Auth-Key", "yYdd8hSrYbRVn1B7e9tssBQxjj3sWzHGng9Ig9FomZQYJ5RrD1yyWPqbOHloRUPe");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("X-TBA-Auth-Key", "Bearer");

            var apiInstance = new DistrictApi(config);
            var districtKey = "2019ne";  // string | TBA District Key, eg `2016fim`
            //var ifModifiedSince = ifModifiedSince_example;  // string | Value of the `Last-Modified` header in the most recently cached response by the client. (optional) 

            try
            {
                List<Event> result = apiInstance.GetDistrictEvents(districtKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DistrictApi.GetDistrictEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}