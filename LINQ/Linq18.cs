using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    public class Linq18
    {
        public static void TaskMain()
        {
            var readPath = Misc.SetPath("Task18.txt", true);
            var writePath = Misc.SetPath("Task18.txt", false);
            var taskData = new List<List<int>>();
            Misc.ParseInts(taskData, readPath);
            foreach (var dataLine in taskData)
            {
                var positiveEven = from i in dataLine where (i%2 == 0 && i > 9 && i< 100) orderby i select i;
                Misc.WriteData(positiveEven, writePath);
            }
        }
    }
}