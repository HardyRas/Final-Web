 using System;
using Microsoft.ML.Data;

namespace malariaPrevalencePrediction
{
    public class Malaria
    {

        [LoadColumn(0)]
        public float month;

        [LoadColumn(1)]
        public float temperature;

        [LoadColumn(2)]
        public float rainfall;

        [LoadColumn(3)]
        public float al6;

        [LoadColumn(4)]
        public float al12;

        [LoadColumn(5)]
        public float al18;

        [LoadColumn(6)]
        public float al24;

        [LoadColumn(7)]
        public float artesunate_injections;

        [LoadColumn(8)]
        public float rdts;

        [LoadColumn(9)]
        public float sps;

        [LoadColumn(10)]
        public float prevalenceUne;

    }
    public class MalariaPrevalencePrediction
    {
        [ColumnName("Score")]
        public float prevalenceUne;

    }

}
