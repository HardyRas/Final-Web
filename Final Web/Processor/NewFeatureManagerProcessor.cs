using Final_Web.Repository;
using System.Threading.Tasks;
using System.Web;
using WebApi.Models;

namespace Final_Web.Processor
{
    public class NewFeatureManagerProcessor
    {
        public static async Task<bool> ProcessNewFeature(NewFeature feature)
        {
            //process, calculate, format etc
            return await NewFeatureManageRepository.SaveNewFeature(feature);

        }
    }
}