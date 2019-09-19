using Microsoft.ML;
using System;
using System.IO;
using WebApi.DataModels;


namespace Final_Web
{
    public partial class ikeregeWardPrePred : System.Web.UI.Page
    {
        // three fields to hold the paths to the files with data sets and the file to save
        //the model, and a global variable for the TextLoader

        static readonly string _trainDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "malaria-train2.csv");
        //static readonly string _testDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "malaria-trialtest2.csv");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "Model.zip");
      //  static TextLoader _textLoader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PredictPrevalence_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Environment.CurrentDirectory);

            //When building a model with ML.NET you start by creating an ML Context. 
            //This is comparable conceptually to using DbContext in Entity Framework. 
            //The environment provides a context for the machine learning job that can be used for 
            //1. exception tracking and 2. logging.

            MLContext mlContext = new MLContext(seed: 0);
            var model = Train(mlContext, _trainDataPath);
            TestSinglePrediction(mlContext, model);


        }

        public static ITransformer Train(MLContext mlContext, string DataPath)
        {


            IDataView dataView = mlContext.Data.LoadFromTextFile<Malaria>(DataPath, hasHeader: true, separatorChar: ',');

           // IDataView dataView = _textLoader.Load(DataPath);
            //pipeline stores label
            var pipeline = mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: "prevalenceUne")


            .Append(mlContext.Transforms.Concatenate("Features", "temperature", "rainfall", "al6", "al12", "al18", "al24"))

                        //Choosing the algorithm.
                        //decision trees?

                        //refer to your fast tree info.txt
                        .Append(mlContext.Regression.Trainers.FastTree());

            Console.WriteLine("=============== Create and Train the Model ===============");
            var model = pipeline.Fit(dataView);
            Console.WriteLine("=============== *****End of training ******===============");

            Console.WriteLine();


            SaveModelAsFile(mlContext, model);

            return model;
        }

        private static void TestSinglePrediction(MLContext mlContext, ITransformer model)
        {

            //Creates a single comment of test data.
            //Predicts fare amount based on test data.
            //Combines test data and predictions for reporting.
            //Displays the predicted results.

            //Expensive


            //expensive
            var predictionFunction = mlContext.Model.CreatePredictionEngine<Malaria, MalariaPrevalencePrediction>(model);

            //instance of a malaria data
            //to get predictions from

            //THIS IS THE VARIABILITY.
            //exists in all wards
            var MalariaExample = new Malaria()
            {

                // to receive user input for max accuracy
                //obtained from the time series anlaysis.
                temperature = 21,
                rainfall = 242,
                al6 = 264,
                al12 = 180,
                al18 = 10,
                al24 = 4,

            };

            var prediction = predictionFunction.Predict(MalariaExample);

            Console.WriteLine($"*********************************************************************************************");
            Console.WriteLine($"Predicted prevalence for the next month: {prediction.prevalenceUne:0}");
            Console.WriteLine($"*********************************************************************************************");
        }

        //straight forward write to file after zipping procedure.
        //this happens after training.
        private static void SaveModelAsFile(MLContext mlContext, ITransformer loadedmodel)
        {
            using (var filestream = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
                mlContext.Model.Save(loadedmodel, inputSchema: null, filestream);

            Console.WriteLine("The model has been saved in: \n{0}", _modelPath);
        }
    }
}