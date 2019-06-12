namespace malariaPrevalencePrediction
{
    static class TestMalaria
    {

        internal static readonly Malaria prevalence1 = new Malaria
        {
            temperature = 24,
            rainfall= 1,
            al6 = 1,
            al12 = 1,
            al18 = 0,
            al24 = 0,
            artesunate_injections = 0,
            rdts = 0,
            sps = 1,
            prevalenceUne = 0 // predict it.

        };
    }

}