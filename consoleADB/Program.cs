using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleA
{
    public class Cmd
    {
        private bool IsLesten = false;
        private bool IsOut = false;
        private Process proc = new Process();
        public void RunCmd(string cmd)
        {
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            while (true)
            {
                if (IsOut) break;
                try
                { 
                    string outStr = proc.StandardOutput.ReadLine();
                    Console.WriteLine(outStr);
                    if (!IsLesten && outStr == "ListeningPlease")
                    {
                        Console.WriteLine("开始收集数据");
                        IsLesten = true;
                    }
                    else if (IsLesten)
                    {
                        Console.WriteLine(outStr);
                    }
                }
                catch
                {
                    break;
                }
            }
        }
        public void stop()
        {
            IsOut = true;
            proc.Close();
            proc.Dispose();
            Console.WriteLine("停止收集数据");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cmd c = new Cmd();
            var command = string.Format("java -jar {0} {1} {2} {3}", "F:\\client.jar", "VerticalSendSwerveSystem", "192.168.2.192", "f:\\simuSystem.fed");
            new Thread(() =>
            {
                c.RunCmd(command);
            }).Start();
            Console.Read();
            c.stop();
            Console.Read();
        }
    }
}
