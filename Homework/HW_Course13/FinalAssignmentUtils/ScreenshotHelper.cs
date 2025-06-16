using OpenQA.Selenium;
using System;
using System.IO;

namespace FinalAssignmentUtils
{
    public static class ScreenshotHelper
    {
        public static string CaptureScreen(IWebDriver driver)
        {
            try
            {
                // Take screenshot
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

                // Generate filename and folder
                string imageName = $"screenshot-{DateTime.Now:yyyyMMdd-HHmmss}.png";

                // Create a directory for screenshots if it doesn't exist
                var currentDir = AppDomain.CurrentDomain.BaseDirectory;
                var projectRoot = Path.GetFullPath(Path.Combine(currentDir, @"..\..\..\..\FinalAssignmentTests"));
                var screenshotDir = Path.Combine(projectRoot, "Screenshots");
                Directory.CreateDirectory(screenshotDir);

                var imagePath = Path.Combine(screenshotDir, imageName);                

                // Save screenshot as PNG (only one argument supported)
                screenshot.SaveAsFile(imagePath); 

                return imagePath;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ScreenshotHelper] Screenshot failed: " + ex.Message);
                return null;
            }
        }
    }
}
