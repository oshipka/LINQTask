using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    public class Linq19
    {
        public static void TaskMain()
        {
            var readPath = Misc.SetPath("Task19.txt", true);
            var writePath = Misc.SetPath("Task19.txt", false);
            var taskData = new List<List<string>>();
            Misc.ParseStrings(taskData, readPath);
            foreach (var dataLine in taskData)
            {
                var sortedWords = dataLine.OrderBy(x => x, new WordsComparer());
                foreach (var variable in sortedWords)
                {
                    File.AppendAllText(writePath, variable.ToString());
                    File.AppendAllText(writePath, " ");
                }
                File.AppendAllText(writePath, Environment.NewLine);
            }
        }
    }

    class WordsComparer:IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return y != null && (x != null && x.Length == y.Length) ? x[0].CompareTo(y[0]) : x.Length.CompareTo(y.Length);
        }
    }
}