using Final_Web.Repository;
using System.Threading.Tasks;
using System.Web;
using WebApi.Models;

namespace Final_Web.Processor
{
    public class NewFeatureFinalWebProcessor
    {
        public static async Task<bool> ProcessNewFeature(NewFeature feature)
        {

            //process, calculate, format etc
            //does nothing just yet only returns as part of a process.
            return await NewFeatureFinalWebRepository.SaveNewFeature(feature);

        }
    }
}