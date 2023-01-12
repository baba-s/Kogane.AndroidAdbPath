using UnityEditor.Android;

namespace Kogane
{
    public static class AndroidAdbPath
    {
        public static string Path => $"{AndroidExternalToolsSettings.sdkRootPath}/platform-tools/adb";
    }
}