//for naming conventions..
//we dont require to  know what kind of object we are referring to
//it is allowed to just understand the kind of objects you are returning or receiving.
//you can also avoid cluster in the process.

using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace Final_Web.Repository
{
    //this class calls the web api named WebApi accessed through
    //the added dll reference.
    //it is a client side control that allows you to call the webApi to do something
    //in this case POST
    public class NewFeatureFinalWebRepository
    {
        //contains a function that receives details from a class through an object
        //this object then has its data converted into json format as defined in the variable name JsonContent
        public static async Task<bool> SaveNewFeature(NewFeature feature)
        {
            var Client = new HttpClient(); //special guy ...has a lot of libraries that attribute to post get
                                           //put and others relative to the async

            var JsonContent = JsonConvert.SerializeObject(feature);


            //mode of transfer over the hhtp protocol
            //json is not enough moving data over a webservice needs to be undertandable
            //further doumentation is in STRINGCONTENT();
            var httpContent = new StringContent(JsonContent, Encoding.UTF8, "application/json");

            //URL to the web service created earlier.
            //http://localhost:51217
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/await for the asyn await documentation
            var Response = await Client.PostAsync("http://localhost:51217/SaveNewFeature", httpContent);

            //just to make sure its readable.
            //just in case
            //its being received as a bool so
            var RepsonseString = await Response.Content.ReadAsStringAsync();

            //..sorry ..so...
            if (RepsonseString == "false")
            {
                return false;
            }
            else
                return true;

        }
    }
}