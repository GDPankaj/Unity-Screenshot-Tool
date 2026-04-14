using UnityEngine;
using UnityEditor;
using GDCP.ScreenshotTool;
namespace GDCP.ScreenshotTool.Editor
{
    public class ScreenshotToolWindow : EditorWindow
    {
        [SerializeField]private FolderPath fullPath = new("C:/Screenshots/screenshot.png");
        private SerializedObject serializedObj;
        private SerializedProperty m_fullPathProperty;

        [MenuItem("Window/ScreenshotUtilityByGDP/ScreenshotWindow")]
        public static void Open()
        {
            GetWindow<ScreenshotToolWindow>("Screenshot");
        }

        private void OnEnable()
        {
            serializedObj = new SerializedObject(this);
            m_fullPathProperty = serializedObj.FindProperty("fullPath");
        }

        private void OnGUI()
        {
            EditorGUILayout.PropertyField(m_fullPathProperty);
        }
    }
}
