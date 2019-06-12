using System;
using System.IO;
using Microsoft.Data.DataView;
using Microsoft.ML;
using Microsoft.ML.Data;


namespace malariaPrevalencePrediction
{

    //Defining data and model paths

    class Program
        {

            // three fields to hold the paths to the files with data sets and the file to save
            //the model, and a global variable for the TextLoader

            static readonly string _trainDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "malaria-train2.csv");
            static readonly string _testDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "malaria-trialtest2.csv");
            static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "Model.zip");

        //encapsulated: im now using property.
        public static string TestDataPath => _testDataPath;

        static void Main(string[] args)
            {

                //When building a model with ML.NET you start by creating an ML Context. 
                //This is comparable conceptually to using DbContext in Entity Framework. 
                //The environment provides a context for your machine learning job that can be used for 
                //1. exception tracking and 2. logging.

                MLContext mlContext = new MLContext(seed: 0);

            //PROTOTYPING FUNCTIONS

            //Train Function
            var model = Train(mlContext,_trainDataPath);

            ////Evaluate Function
            //EvaluateModel(mlContext,model);

            //testSinglePrediction
            TestSinglePrediction(mlContext);

            Console.ReadKey();
            }


        //Train methods executes the following
        //..Loads the data.
        //..Extracts and transforms the data.
        //..Trains the model.
        //..Saves the model as .zip file.
        //..Returns the model.
        private static ITransformer Train(MLContext mlContext, string DataPath)
                {


            IDataView dataView = mlContext.Data.LoadFromTextFile<Malaria>(DataPath, hasHeader: true, separatorChar: ',');
            var pipeline = mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: "prevalenceUne")


            .Append(mlContext.Transforms.Concatenate("Features", "month", "temperature", "rainfall", "al6", "al12", "al18", "al24", "artesunate_injections", "rdts", "sps" ))

                        //Choosing the algorithm.
                        //decision trees?

                        //refer to your fast tree info.txt
                        .Append(mlContext.Regression.Trainers.FastTree());

                Console.WriteLine("=============== Create and Train the Model ===============");

                // this cannot run because of data lacking/ insufficiency.
                //call an exceptional error upon compiling.
                var model = pipeline.Fit(dataView);
                Console.WriteLine("=============== *****End of training ******===============");

                Console.WriteLine();


                SaveModelAsFile(mlContext, model);

                return model; 
                }

        //private static void EvaluateModel(MLContext mLContext, ITransformer model)
        //{

        //    //check the schema models of the regression.evaluate function
        //    //must be a syntax error with the data arrangement
        //    //excel to learning pipeline.
        //    IDataView dataView = mLContext.Data.LoadFromTextFile<Malaria>(_testDataPath, hasHeader: true, separatorChar: ',');
        //    var predictions = model.Transform(dataView);

        //    //ERROR INASEMA LABEL COLUMN 'LABEL' NOT FOUND!!
        //    RegressionMetrics metrics = mLContext.Regression.Evaluate(dataView, "Label", "Score");

        //    Console.WriteLine($"*       R2 Score:      {metrics.RSquared:0.##}");
        //    Console.WriteLine($"*       RMS loss:      {metrics.Rms:#.##}");

        //}


        private static void TestSinglePrediction(MLContext mlContext)
            {

                                //Creates a single comment of test data.
                                //Predicts fare amount based on test data.
                                //Combines test data and predictions for reporting.
                                //Displays the predicted results.

                            ITransformer loadedModel;

                            using (var stream = new FileStream(_modelPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                            loadedModel = mlContext.Model.Load(stream);
                            } 


                            //involve the two classes from the train namespace
                            var predictionFunction = loadedModel.CreatePredictionEngine<Malaria, MalariaPrevalencePrediction>(mlContext);

                            //instance of a malaria data
                            //to get predictions from

                            //THIS IS THE VARIABILITY.

                            var MalariaExample = new Malaria()
                                        {


                                            // to receive user input for max accuracy
                                            //obtained from the time series anlaysis (prediction!)
                                            temperature = 22,
                                            rainfall = 337,
                                            al6 = 416,
                                            al12 = 577,
                                            al18 = 168,
                                            al24 = 303,
                                            
                                        };

                                var prediction = predictionFunction.Predict(MalariaExample);
                                Console.WriteLine($"*********************************************************************************************");
                                Console.WriteLine($"Predicted prevalence for the next month: {prediction.prevalenceUne:0}");
                                Console.WriteLine($"*********************************************************************************************");
            }

        //straight forward write to file after zipping procedure.

            private static void SaveModelAsFile(MLContext mlContext, ITransformer model)
            {
                using (var filestream = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
                    mlContext.Model.Save(model, filestream);

                Console.WriteLine("The model has been saved in: \n{0}", _modelPath);
            }
    }
    }