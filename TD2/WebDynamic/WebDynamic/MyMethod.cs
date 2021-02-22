using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace WebDynamic
{
    class MyMethod
    {
        public static string Hello(string name1, string name2)
        {
            //Question 4:
            //string respond = "<HTML><BODY> Hello " + name1 + " and " + name2 + "from myMethod.</BODY></HTML>";


            //Question 5:
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\50337\Desktop\soc\eiin839\TD2\WebDynamic\myExe\bin\Debug\net5.0\myExe.exe";
            string argument = name1 + " " + name2;
            start.Arguments = argument;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            string respond;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    respond = reader.ReadToEnd();
                }
            }

            return respond;
        }
    }
}
