using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using API.DataModels;


[Route("api/[controller]")]
[ApiController]
public class PredictController : ControllerBase
{

    private readonly PredictionEnginePool<PrevalenceData, MalariaPrevalencePrediction> _predictionEnginePool;

    public PredictController(PredictionEnginePool<PrevalenceData, MalariaPrevalencePrediction> predictionEnginePool)
    {
        _predictionEnginePool = predictionEnginePool;
    }

    [HttpPost]
    public ActionResult<float> Post([FromBody] PrevalenceData input)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        MalariaPrevalencePrediction prediction = _predictionEnginePool.Predict(input);

        float prevalence = Convert.ToInt64(prediction.Prediction);

        return Ok(prevalence);
    }
}