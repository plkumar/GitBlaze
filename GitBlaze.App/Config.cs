using System;
namespace GitBlaze.App
{
    public class Config
    {
        private static string s_gitKey = string.Empty;

        public Config()
        {
        }

        public static string GitKey { get => s_gitKey; set => s_gitKey = value; }
    }
}
