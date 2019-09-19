using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;
using API.DataModels;

namespace API.Controllers
{


    [EnableCors("http://localhost:51014", "*", "*")]
    public class PredictController : ControllerBase
    {

      //  public PredictionModel<Malaria, MalariaPrevalencePrediction> _predictionModel;
        public PredictController()
        {
          //  _predictionModel = PredictionModel.ReadAsync<Malaria, MalariaPrevalencePrediction>("@./MLModel/Model.zip").Result;
        }
    }
}