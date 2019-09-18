using Microsoft.ML.Data;

namespace WebApi.DataModels
{
    public class Malaria
    {

        [LoadColumn(0)]
        public System.DateTime month;

        [LoadColumn(1)]
        public int temperature;

        [LoadColumn(2)]
        public float rainfall;

        [LoadColumn(3)]
        public int al6;

        [LoadColumn(4)]
        public int al12;

        [LoadColumn(5)]
        public int al18;

        [LoadColumn(6)]
        public int al24;

        [LoadColumn(7)]
        [ColumnName("Label")]
        public int prevalenceUne;

    }
}
