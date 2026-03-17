using UnityEngine;
using UnityEditor;

namespace GDCP.ScreenshotTool.Editor
{
    public class ScreenshotToolWindow : EditorWindow
    {
        private string fullPath = "C:/Screenshots/screenshot.png";
        private int superSize = 1;
        private int number = 1;

        [MenuItem("Window/ScreenshotUtilityByGDP/ScreenshotWindow")]
        public static void Open()
        {
            GetWindow<ScreenshotToolWindow>("Screenshot");
        }

        private void OnGUI()
        {
            fullPath = EditorGUILayout.TextField("Full Path", fullPath);
            superSize = EditorGUILayout.IntSlider("Super Size", superSize, 1, 5);

            GUILayout.Space(10);

            if (GUILayout.Button("Capture"))
            {
                string file = fullPath + number.ToString() + ".png";
                number++;
                ScreenCapture.CaptureScreenshot(file, superSize);
                Debug.Log("Saved to: " + fullPath);
            }
        }
    }
}
