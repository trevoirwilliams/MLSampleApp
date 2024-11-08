
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace PredictiveModel.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            PredictiveModel.ModelInput sampleData = new PredictiveModel.ModelInput()
            {
                UDI = 1F,
                Product_ID = @"M14860",
                Type = @"M",
                Air_temperature = 298.1F,
                Process_temperature = 308.6F,
                Rotational_speed = 1551F,
                Torque = 42.8F,
                Tool_wear = 0F,
                TWF = 0F,
                HDF = 0F,
                PWF = 0F,
                OSF = 0F,
                RNF = 0F,
            };


            Console.WriteLine("Using model to make single prediction -- Comparing actual Machine_failure with predicted Machine_failure from sample data...\n\n");


            Console.WriteLine($"UDI: {1F}");
            Console.WriteLine($"Product_ID: {@"M14860"}");
            Console.WriteLine($"Type: {@"M"}");
            Console.WriteLine($"Air_temperature: {298.1F}");
            Console.WriteLine($"Process_temperature: {308.6F}");
            Console.WriteLine($"Rotational_speed: {1551F}");
            Console.WriteLine($"Torque: {42.8F}");
            Console.WriteLine($"Tool_wear: {0F}");
            Console.WriteLine($"Machine_failure: {0F}");
            Console.WriteLine($"TWF: {0F}");
            Console.WriteLine($"HDF: {0F}");
            Console.WriteLine($"PWF: {0F}");
            Console.WriteLine($"OSF: {0F}");
            Console.WriteLine($"RNF: {0F}");


            var sortedScoresWithLabel = PredictiveModel.PredictAllLabels(sampleData);
            Console.WriteLine($"{"Class",-40}{"Score",-20}");
            Console.WriteLine($"{"-----",-40}{"-----",-20}");

            foreach (var score in sortedScoresWithLabel)
            {
                Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
            }
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
