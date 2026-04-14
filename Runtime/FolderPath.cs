using System;
using UnityEngine;

namespace GDCP.ScreenshotTool
{
    [Serializable]
    public class FolderPath
    {
        [SerializeField]string path;
        public string Path => path;
        public FolderPath(string path)
        {
            this.path = path;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }
    }
}
