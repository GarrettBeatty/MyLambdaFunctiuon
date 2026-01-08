# AWS Lambda Function for Lambda Test Tool

This is a simple .NET class library Lambda function designed to work with the AWS Lambda Test Tool v2.

## Project Structure

- **Function.cs** - Contains the Lambda function handler
- **MyLambdaFunction.csproj** - Project configuration with Lambda dependencies
- **test-event.json** - Sample test event for testing the Lambda function
- **Properties/launchSettings.json** - Configuration for running with the Lambda Test Tool

## Function Handler

The function has one handler:
- `FunctionHandler(string input, ILambdaContext context)` - Accepts a string input and returns a greeting message

## Setup Instructions

### 1. Install the AWS Lambda Test Tool

```bash
dotnet tool install -g amazon.lambda.testtool
```

Or update if already installed:

```bash
dotnet tool update -g amazon.lambda.testtool
```

### 2. Build the Project

```bash
cd MyLambdaFunction
dotnet build
```

### 3. Run the Lambda Function

#### Option A: Use Visual Studio Code (Recommended)

1. Open the project in VS Code
2. Press `F5` or go to Run > Start Debugging
3. Select the **LambdaRuntimeClient_FunctionHandler** profile
4. The Lambda Test Tool will start automatically

#### Option B: Run the Test Tool and Lambda Separately

**Terminal 1 - Start the Lambda Test Tool:**
```bash
dotnet lambda-test-tool --lambda-emulator-port 5050
```

** Start your Lambda function:**
1. in visual studio click run


Then navigate to `http://localhost:5050` in your browser.

## Testing the Function

1. In the Lambda Test Tool web interface:
   - The function should automatically appear as **MyLambdaFunction**
   - Enter test input (e.g., `"Hello Lambda Test Tool!"`)
   - Click **Execute Function**

2. Using the test event file:
   - Copy the content from `test-event.json`
   - Paste it into the test input in the web interface
   - Execute the function

3. Expected response:
   ```json
   "Hello from Lambda! You sent: Hello Lambda Test Tool!"
   ```