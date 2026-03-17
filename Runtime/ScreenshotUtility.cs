using UnityEngine;

namespace GDP.ScreenshotTool
{
    public class ScreenshotUtility
    {
        public void TakeScreenshot(string path)
        {
            ScreenCapture.CaptureScreenshot(path);
        }
        public void TakeScreenshot(string path, int superSize)
        {
            ScreenCapture.CaptureScreenshot(path, superSize);
        }
        public void TakeScreenshot(string path, ScreenCapture.StereoScreenCaptureMode mode)
        {
            ScreenCapture.CaptureScreenshot(path, mode);
        }
    }
}
