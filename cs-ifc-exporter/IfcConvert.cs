using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfcExport
{
    public class IfcConvert
    {
        public static void InstallIfcConvert()
        {
            InstallBinaryFile("IfcConvert.exe", Properties.Resources.IfcConvert);
        }

        private static void InstallBinaryFile(string filename, byte[] bytes)
        {
            string path = Path.Combine(IOUtils.AssemblyDirectory, filename);
            if (File.Exists(path)) return;
            File.WriteAllBytes(path, bytes);
        }

        public static void Convert(string source, string target)
        {
            InstallIfcConvert();

            string executablePath = Path.Combine(IOUtils.AssemblyDirectory, "IfcConvert.exe");

            var info = new ProcessStartInfo();
            info.FileName = string.Format("\"{0}\"", executablePath);
            info.WorkingDirectory = IOUtils.AssemblyDirectory;
            info.Arguments = string.Format("\"{0}\" \"{1}\"", source, target);

            info.RedirectStandardInput = false;
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;


            using (var proc = new Process())
            {
                proc.StartInfo = info;
                proc.Start();
                Console.WriteLine(proc.StandardOutput.ReadToEnd());
            }
        }
    }
}

