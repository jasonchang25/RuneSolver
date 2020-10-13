using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
namespace RuneSolver
{
    class Program
    {
        static protected Guid _projectId;
        static protected string _modelName;
        static protected string _ENDPOINT;
        static protected string _predictionKey;

        static void Main(string[] args)
        {
            // Add your Azure Custom Vision endpoint
            _projectId = Guid.Parse("e50b73f5-e383-4c0f-a2b3-63140dea92a8");
            _ENDPOINT = "https://runeclassifier-prediction.cognitiveservices.azure.com/";
            _predictionKey = "e587c896f1664f8dacb25ce70dde10d9";
            _modelName = "RuneSolver";
            CustomVisionPredictionClient predictionApi = AuthenticatePrediction(_ENDPOINT, _predictionKey);
            var runeImage = Path.Combine("2.png");
            var timeTracker = 0;
            while (true)
            {
                if (timeTracker == 0)
                {
                    OpenEliteBox();
                    timeTracker = 200000;
                }
                if (File.Exists(runeImage))
                {
                    var solution = GetSolution(predictionApi, runeImage);
                    solution.ForEach(c => Console.Write(c.TagName + ","));
                    SolveRune(solution);
                    Console.WriteLine("Rune Solved");
                    SummonHeal();
                    File.Delete(runeImage);
                }
                Thread.Sleep(5000);
            }
        }

        private static void OpenEliteBox()
        {
            for (var i = 0; i < 5; i++)
            {
                KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_5, false, KeyInput.InputType.Keyboard);
                Thread.Sleep(250);
            }            
        }

        private static void SummonHeal()
        {
            for (var i = 0; i < 3; i++)
            {
                KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_S, false, KeyInput.InputType.Keyboard);
                Thread.Sleep(250);
            }
        }

        private static void SolveRune(List<PredictionModel> solution)
        {
            foreach (var key in solution)
            {
                switch (key.TagName)
                {
                    case "Left":
                        KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_LEFTARROW, false, KeyInput.InputType.Keyboard);
                        break;
                    case "Right":
                        KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_RIGHTARROW, false, KeyInput.InputType.Keyboard);
                        break;
                    case "Down":
                        KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_DOWNARROW, false, KeyInput.InputType.Keyboard);
                        break;
                    case "Up":
                        KeyInput.SendKey(KeyInput.DirectXKeyStrokes.DIK_UPARROW, false, KeyInput.InputType.Keyboard);
                        break;
                    default:
                        break;                    
                }
                Thread.Sleep(500);
            }
        }

        private static CustomVisionPredictionClient AuthenticatePrediction(string endpoint, string predictionKey)
        {
            // Create a prediction endpoint, passing in the obtained prediction key
            CustomVisionPredictionClient predictionApi = new CustomVisionPredictionClient(new ApiKeyServiceClientCredentials(predictionKey))
            {
                Endpoint = endpoint
            };
            return predictionApi;
        }

        private static List<PredictionModel> GetSolution(CustomVisionPredictionClient predictionApi, string imageFile)
        {
            // Make a prediction against the new project
            Console.WriteLine("Making a prediction:");
            using (var stream = File.OpenRead(imageFile))
            {
                var result = predictionApi.DetectImage(_projectId, _modelName, stream);
                var solution = result.Predictions.Take(4).OrderBy(c => c.BoundingBox.Left).ToList();                
                return solution;
            }
        }
    }
}
