using MLDemo;

namespace MLDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = "Then, as if I hadn't wasted enough of my life there, they poured salt in the wound by drawing out the time it took to bring the check."
            };

            // Load model and predict output of sample data
            var result = SentimentModel.Predict(sampleData);

            // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
            var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
