using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    public class Linq20
    {
        public static void TaskMain()
        {
            var readPath = Misc.SetPath("Task20.txt", true);
            var writePath = Misc.SetPath("Task20.txt", false);
            var taskData = new List<List<int>>();
            Misc.ParseInts(taskData, readPath);
            if (taskData.Count % 2 != 0)
            {
                throw new InvalidDataException($"Not enough data, count = {taskData.Count}");
            }
            for (var k =1; k<taskData.Count; k+=2)
            {
                var D = taskData[k - 1][0];
                var greaterThanD = taskData[k].SkipWhile(x => x < D).Where(x=>(x%2==1 && x>0)).Reverse();
                Misc.WriteData(greaterThanD, writePath);
            }
        }
    }
}