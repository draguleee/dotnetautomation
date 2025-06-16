using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

/// <summary>
/// Reporter - represents the class for generating Extent Reports for test execution results.
/// </summary>
public static class Reporter
{
    // Create class instances 
    public static ExtentReports Extent { get; set; }                                // Holds the report
    public static ExtentSparkReporter SparkReporter { get; set; }                   // Configures the report output
    public static ThreadLocal<ExtentTest> test = new ThreadLocal<ExtentTest>();     // Holds the current test instance for parallel execution

    /// <summary>
    /// InitReport - initializes the Extent Report with the specified configuration.
    /// </summary>
    public static void InitReport()
    {
        // If the extent report is already initialized, return
        if (Extent != null) return;

        // Create a directory for the report if it doesn't exist
        var currentDir = AppDomain.CurrentDomain.BaseDirectory;
        var projectRoot = Path.GetFullPath(Path.Combine(currentDir, @"..\..\..\..\FinalAssignmentTests"));
        var reportDir = Path.Combine(projectRoot, "TestResults");
        Directory.CreateDirectory(reportDir);

        // Define the path for the report file
        var reportPath = Path.Combine(reportDir, "ExtentReport.html");

        // Initialize the ExtentSparkReporter with the report path and configuration
        SparkReporter = new ExtentSparkReporter(reportPath);
        SparkReporter.Config.DocumentTitle = "Automation Report";
        SparkReporter.Config.ReportName = "Regression Test Report";
        SparkReporter.Config.Theme = Theme.Standard;

        // Initialize the ExtentReports instance with the Spark reporter
        Extent = new ExtentReports();
        Extent.AttachReporter(SparkReporter);
    }

    public static ExtentTest CurrentTest => test.Value;

    /// <summary>
    /// CrateTest - creates a new test in the Extent Report.
    /// </summary>
    /// <param name="testName"></param>
    public static void CreateTest(string className, string testName)
    {
        var parent = Extent.CreateTest(className);
        test.Value = parent.CreateNode(testName);
    }

    /// <summary>
    /// LogInfo - logs an informational message in the report.
    /// </summary>
    /// <param name="message"></param>
    public static void LogInfo(string message) => test.Value.Info(message);

    /// <summary>
    /// LogPass - logs a passed test message in the report.
    /// </summary>
    /// <param name="message"></param>
    public static void LogPass(string message) => test.Value.Pass(message);

    /// <summary>
    /// LogFail - logs a failed test message in the report.
    /// </summary>
    /// <param name="message"></param>
    public static void LogFail(string message) => test.Value.Fail(message);

    /// <summary>
    /// AddScreenshot - adds a screenshot to the report.
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="title"></param>
    public static void AddScreenshot(string filePath, string title = "Screenshot")
    {
        test.Value.AddScreenCaptureFromPath(filePath, title);
    }

    /// <summary>
    /// FinalizeTest - finalizes the test in the Extent Report based on the test status.
    /// </summary>
    public static void FinalizeTest()
    {
        var status = TestContext.CurrentContext.Result.Outcome.Status;
        var message = TestContext.CurrentContext.Result.Message;
        var stacktrace = TestContext.CurrentContext.Result.StackTrace;

        switch (status)
        {
            case TestStatus.Failed:
                test.Value.Fail($"<b>Test Failed</b><br>{message}<br><pre>{stacktrace}</pre>");
                break;
            case TestStatus.Skipped:
                test.Value.Skip("Test Skipped");
                break;
            case TestStatus.Passed:
                test.Value.Pass("Test Passed");
                break;
        }
    }

    /// <summary>
    /// FlushReport - flushes the Extent Report to write all the logs and results to the report file.
    /// </summary>
    public static void FlushReport()
    {
        Extent.Flush();
    }
}
