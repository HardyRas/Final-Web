using System;
using Microsoft.ML;
using Microsoft.ML.Core.Data;
using Microsoft.ML.Data;
using System.IO;
using Microsoft.Data.DataView;


namespace CLIAPP1
{
        //Defining data and model paths

        class Program
        {

            // three fields to hold the paths to the files with data sets and the file to save
            //the model, and a global variable for the TextLoader

            static string trainDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "malaria-train2.csv");
           //static string testDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "malaria-trialtest2.csv");
            static  string modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "Model.zip");
            static TextLoader textLoader;
        static void Main(string[] args)
            {
                Console.WriteLine("****************************************************");
                Console.WriteLine("This process is happening locally in the directory mentioned:");
                Console.WriteLine("****************************************************");
                Console.WriteLine(Environment.CurrentDirectory);

                //When building a model with ML.NET you start by creating an ML Context. 
                //This is comparable conceptually to using DbContext in Entity Framework. 
                //The environment provides a context for the machine learning job that can be used for 
                //1. exception tracking and 2. logging.

                MLContext mlContext = new MLContext(seed: 0);

                textLoader = mlContext.Data.CreateTextLoader
                      (new TextLoader.Arguments()
                      {
                          Separators = new[] { ',' },
                          HasHeader = true,
                          Column = new[]
                              {
                                                        new TextLoader.Column("temperature", DataKind.R4, 1),
                                                        new TextLoader.Column("rainfall", DataKind.R4, 2),
                                                        new TextLoader.Column("al6", DataKind.R4, 3),
                                                        new TextLoader.Column("al12", DataKind.R4, 4),
                                                        new TextLoader.Column("al18", DataKind.R4, 5),
                                                        new TextLoader.Column("al24", DataKind.R4, 6),
                                                        new TextLoader.Column("prevalenceUne", DataKind.R4, 7)
                              }
                      }
                      );

                var model = Train(mlContext, trainDataPath);
                TestSinglePrediction(mlContext);
            Console.ReadLine();
            }


        //Train methods executes the following
        //..Loads the data.
        //..Extracts and transforms the data.
        //..Trains the model.
        //..Saves the model as .zip file.
        //..Returns the model.
        public static ITransformer Train(MLContext mlContext, string DataPath)
            {


                //IDataView dataView = mlContext.Data.LoadFromTextFile<Malaria>(DataPath, hasHeader: true, separatorChar: ',');

                IDataView dataView = textLoader.Read(DataPath);
                //pipeline stores label
                var pipeline = mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: "prevalenceUne")


                .Append(mlContext.Transforms.Concatenate("Features", "temperature", "rainfall", "al6", "al12", "al18", "al24"))

                            //Choosing the algorithm.
                            //decision trees?

                            //refer to your fast tree info.txt
                            .Append(mlContext.Regression.Trainers.FastTree());

                Console.WriteLine("\t\t\t=============== The model is being built....  ===============");
                Console.WriteLine("\t\t\t=============== Training has begun...  ===============");
                Console.WriteLine("\t\t\t=============== Please wait...  ===============");
                var model = pipeline.Fit(dataView);
                Console.WriteLine("\t\t\t=============== *****End of training ******===============");

                Console.WriteLine();


                SaveModelAsFile(mlContext, model);

                return model;
            }


        private static void TestSinglePrediction(MLContext mlContext)
            {

            int Temp, Rain, ALsix, ALtwelve, ALeighteen, ALtwennyfour = 0;

                //Creates a single comment of test data.
                //Predicts fare amount based on test data.
                //Combines test data and predictions for reporting.
                //Displays the predicted results.

                //Expensive
                ITransformer loadedModel;

                using (var stream = new FileStream(modelPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))

                {

                    loadedModel = mlContext.Model.Load(stream);

                }

                //expensive
                var predictionFunction = loadedModel.CreatePredictionEngine<Malaria, MalariaPrevalencePrediction>(mlContext);

            //instance of a malaria data
            //to get predictions from

            //THIS IS THE VARIABILITY.
            //exists in all wards
            Console.WriteLine("\n\t\t\t****************************************");
            Console.WriteLine("\t\t\tUSER INPUT FROM FEATURE FORECAST:");
            Console.WriteLine("\t\t\t****************************************");

            Console.WriteLine("\t\t\tWhats the temperature value from the feature forecast:");
            Temp = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("\t\t\tWhats the Rainfall value from the feature forecast:");
            Rain = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\tWhats the AL6 commodity dispensed:");
            ALsix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\tWhats the AL12 commodity dispensed:");
            ALtwelve = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\tWhats the AL18 commodity dispensed:");
            ALeighteen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\tWhats the AL24 commodity dispensed:");
            ALtwennyfour = Convert.ToInt32(Console.ReadLine());


            var MalariaExample = new Malaria()
                {

                    // to receive user input for max accuracy
                    //obtained from the time series anlaysis.
                    temperature = Temp,
                    rainfall = Rain,
                    al6 = ALsix,
                    al12 = ALtwelve,
                    al18 = ALeighteen,
                    al24 = ALtwennyfour,

                };

                var prediction = predictionFunction.Predict(MalariaExample);

                Console.WriteLine($"*********************************************************************************************");
                Console.WriteLine($"Predicted prevalence for the next month: {prediction.prevalenceUne:0}");
                Console.WriteLine($"*********************************************************************************************");
            }

            //straight forward write to file after zipping procedure.
            //this happens after training.
            private static void SaveModelAsFile(MLContext mlContext, ITransformer model)
            {
                using (var filestream = new FileStream(modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
                    mlContext.Model.Save(model, filestream);

                Console.WriteLine("\n\t\t\tThe model has been saved in: \n\t\t\t{0}", modelPath);
            }
        }
}
