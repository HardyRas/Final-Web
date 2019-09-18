using Microsoft.ML.Data;

namespace API.DataModels
{
    public class MalariaPrevalencePrediction
    {
        [ColumnName("PredictedLabel")]
        public float prevalenceUne;

    }
}
