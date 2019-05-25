using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebApi.Models;

namespace Final_Web.Repository
{
    public class NewFeatureManageRepository
    {
        public static async Task<bool> SaveNewFeature(NewFeature feature)
        {
            var Client = new HttpClient();
            var JsonContent = JsonConvert.SerializeObject(feature);
            var httpContent = new StringContent(JsonContent, Encoding.UTF8, "application/json");
            var Response = await Client.PostAsync("http://localhost:51217/SaveNewFeature", httpContent);
            var RepsonseString = await Response.Content.ReadAsStringAsync();

            if (RepsonseString == "false")
            {
                return false;
            }
            else
                return true;

        }
    }
}