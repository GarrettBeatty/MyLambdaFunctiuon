using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MyLambdaFunction;

public class Function
{
    /// <summary>
    /// A simple Lambda function that processes a string input
    /// </summary>
    /// <param name="input">The input string to process</param>
    /// <param name="context">Lambda execution context</param>
    /// <returns>A greeting message with the input</returns>
    public string FunctionHandler(string input, ILambdaContext context)
    {
        context.Logger.LogInformation($"Processing input: {input}");
        
        var response = $"Hello from Lambda! You sent: {input}";
        
        context.Logger.LogInformation($"Response: {response}");
        
        return response;
    }
}
