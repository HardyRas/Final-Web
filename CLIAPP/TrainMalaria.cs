using Microsoft.ML.Data;

namespace CLIAPP
{
    public class Malaria
    {

        [Column("1")]
        public float temperature;

        [Column("2")]
        public float rainfall;

        [Column("3")]
        public float al6;

        [Column("4")]
        public float al12;

        [Column("5")]
        public float al18;

        [Column("6")]
        public float al24;

        [Column("7")]
        public float prevalenceUne;

    }
    public class MalariaPrevalencePrediction
    {
        [ColumnName("Score")]
        public float prevalenceUne;

    }
}
