using HYPERHIRE_Assignment;
using System.IO;
using System.Threading;
using System.Timers;
using HYPERHIRE_Assignment;

Console.WriteLine("Hello, World!");
System.Timers.Timer tmr = new System.Timers.Timer();
tmr.Interval = 15000; // 15 seconds
tmr.Elapsed += FileObserver.ElapsedTime;
tmr.Start();

Console.WriteLine("Monitoring changes in the target file every 15 seconds. Press any key to exit.");
Console.ReadKey();
