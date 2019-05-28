using Final_Web.Processor;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApi.Models;

namespace Final_Web
{
    //this is the controller existing on the clickable href on the UI that triggers entry addition.
    //should look like
    public class NewFeatureFinalWebController : Controller
    {
        public async Task<ActionResult> SaveNewFeature()
        {
            //this hear is picking entries from the input textboxes and 
            var feature = new NewFeature();
            //pick values from

            var success = await NewFeatureFinalWebProcessor.ProcessNewFeature(feature);

            if (success == true)
            {
                ViewBag.Message = "Entries added successfully";
            }

            else
            {
                ViewBag.Message = "Could not perform new entry";
            }
            return View();
        }
    }
}