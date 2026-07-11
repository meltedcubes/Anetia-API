using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AnetiaApi
{
    public class Main
    {
        string FullPath;
        string Path1;
        bool BroWeJustStarted;
        bool IsInjected = false;

        public void InvokeApi()
        {
            Process.Start("Init.exe");
            BroWeJustStarted = true;

            Path1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string Path2 = Path.Combine(Path1, "Anetia\\Workspace");
            FullPath = Path2;

            Directory.CreateDirectory(FullPath);

            string filePath = Path.Combine(FullPath, "exec.txt");
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
        }

        public bool Execute(string Script)
        {
            try
            {
                string filePath = Path.Combine(FullPath, "exec.txt");
                File.WriteAllText(filePath, Script);

                Task.Delay(10);

                string Text = File.ReadAllText(filePath);
                return Text == "";
            }
            catch
            {
                return false;
            }
        }

        public void Inject()
        {
            BroWeJustStarted = false;
            IsInjected = true;
            string OhWow = Path.Combine(Path1, "AnetiaInstallation");
            Process.Start(Path.Combine(OhWow, "Loader.exe"));
            Execute("");
        }

        public bool IsAttached()
        {
            if (!IsInjected)
                return false;

            try
            {
                string filePath = Path.Combine(FullPath, "exec.txt");

                if (!File.Exists(filePath))
                    return false;

                string Text = File.ReadAllText(filePath);
                return Text == "" && !BroWeJustStarted;
            }
            catch
            {
                return false;
            }
        }
    }
}