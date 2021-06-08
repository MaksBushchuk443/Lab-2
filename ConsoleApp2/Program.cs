﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var client = new WebClient())
            {
                var contents = client.DownloadString("https://www.youtube.com/?hl=uk&gl=UA");
                Console.WriteLine(contents);
                string writePath = @"C:\Users\1910506\Desktop\conteten.html";

                try
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(contents);
                    }

                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Дозапись");
                        sw.Write(4.5);
                    }
                    Console.WriteLine("Запись выполнена");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }



            Console.ReadKey();
        }

    }
}
