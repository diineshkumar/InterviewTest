using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HYPERHIRE_Assignment
{
    public static class FileObserver
    {
        static string targetFilePath = "E:\\DiineshKumar\\Interview2024\\newFile.txt";
        static DateTime lastCheckedTime = DateTime.MinValue;

        public static void ElapsedTime(object sender, ElapsedEventArgs e)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(targetFilePath);

            if (lastWriteTime > lastCheckedTime) // Checking if file is modified
            {
                Console.WriteLine($"Change detected in the file at {lastWriteTime}.");
                lastCheckedTime = lastWriteTime;
            }
        }
    }
}
