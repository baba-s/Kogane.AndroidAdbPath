using UnityEditor;
using UnityEngine;

namespace Kogane
{
    public static class AndroidAdbPath
    {
        public static string Path =>
            Application.platform == RuntimePlatform.WindowsEditor
                ? $"{EditorApplication.applicationPath}/../Data/PlaybackEngines/AndroidPlayer/SDK/platform-tools/adb"
                : $"{EditorApplication.applicationPath}/../PlaybackEngines/AndroidPlayer/SDK/platform-tools/adb";
    }
}