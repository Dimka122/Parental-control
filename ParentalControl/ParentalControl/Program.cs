﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ParentalControl 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task.Factory.StartNew(() =>
            //{
            //    while (true)
            //    {
            //        var procceses = from proc in Process.GetProcesses()
            //                        where proc.ProcessName == "chrome"
            //                        select proc;
            //        try
            //        {
            //            foreach (var p in procceses)
            //                p.Kill();
            //        }
            //        catch (Exception)
            //        {
            //        }
            //        Thread.Sleep(500);
            //    }
            //});
            //Console.ReadLine();

            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(2022, 07, 04, 13, 0, 0);
            int result = DateTime.Compare(date1, date2);

            if (date1.Hour < 13)
            {
                Process[] processes = Process.GetProcessesByName("chrome");
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
            else
            {
                Environment.Exit(0);
            }

        }
    }
}

