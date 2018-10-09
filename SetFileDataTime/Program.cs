using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SetFileDataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 8;
            Console.Title = "SetFileDataTime";
            Console.WriteLine("当前系统时间："+DateTime.Now);
            Console.WriteLine("修改的时间点：" );
            Console.ForegroundColor = ConsoleColor.Red;
            string datetime = Console.ReadLine();
            foreach (var item in args)
            {
                if (Directory.Exists(item))
                {
                    Directory.SetCreationTime(item, Convert.ToDateTime(datetime));
                    return;
                }

                File.SetCreationTime(item, Convert.ToDateTime(datetime));
                File.SetLastAccessTime(item, Convert.ToDateTime(datetime));
                File.SetLastWriteTime(item, Convert.ToDateTime(datetime));                
            }
            Console.WriteLine("修改完成！");
        }
    }
}
