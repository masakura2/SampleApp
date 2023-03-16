    using UnityEditor;

    // ReSharper disable once UnusedType.Global
    public static class Export
    {
        // ReSharper disable once UnusedMember.Global
        public static void IOS()
        {
            BuildPipeline.BuildPlayer(Scenes(), "build", BuildTarget.iOS, BuildOptions.None);
        }

        private static string[] Scenes()
        {
            return new [] { "Assets/Scenes/SampleScene.unity" };
        }
    }
