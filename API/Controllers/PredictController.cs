using Microsoft.AspNetCore.Mvc;
using System;
using System.Web.Http.Cors;
using API.DataModels;
using Microsoft.ML;
using WebApi.DataModels;


namespace API.Controllers {

    //enabling Cross origin resource sharing
    //this part is not implemented fully.
    //or it does work...problem is its not reflecting.
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("http://localhost:51014", "*", "*")]
    public class PredictController : ControllerBase
    {
        public PredictionEngine<Malaria, MalariaPrevalencePrediction> _PredictionEngine;

        public PredictController(PredictionEngine<Malaria,MalariaPrevalencePrediction> predictionEngine)
        {

            _PredictionEngine = predictionEngine;
            //_PredictionEngine = PredictionEngine<Malaria, MalariaPrevalencePrediction>, new ("@./MLModel/Model.zip").Result;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //return the result from the prediction pool
        //needs tor return an integer or floating point value.
        //current action posts from a model deployed over the asp.net API.
        public IActionResult Predict();

    }
}