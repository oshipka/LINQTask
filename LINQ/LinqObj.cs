using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    public class LinqObj
    {
        public static void TaskMain()
        {
            var readPath = Misc.SetPath("TaskObj.txt", true);
            var writePath = Misc.SetPath("TaskObj.txt", false);
            var taskData = new List<Client>();
            Misc.ParseClients(taskData, readPath);
            foreach (var dataLine in taskData)
            {
                
                foreach (var variable in positiveEven)
                {
                    File.AppendAllText(writePath, variable.ToString());
                    File.AppendAllText(writePath, " ");
                }
                File.AppendAllText(writePath, Environment.NewLine);
            }
        }
    }
}