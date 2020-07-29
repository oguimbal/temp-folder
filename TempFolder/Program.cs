using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace TempFolder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var prog = Path.Combine(Path.GetTempPath(), "TemporaryFolders");
            if (!Directory.Exists(prog))
                Directory.CreateDirectory(prog);
            int i = 0;
            string p;
            while (Directory.Exists(p = Path.Combine(prog, i++.ToString())) && (Directory.EnumerateFiles(p).Any() || Directory.EnumerateDirectories(p).Any() )) { }
            Directory.CreateDirectory(p);
            Process.Start(p);
        }
    }
}
