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
                Misc.WriteData(sortedWords, writePath);
            }
        }
    }

    internal class WordsComparer:IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length == y.Length ? -string.CompareOrdinal(x, y) : x.Length.CompareTo(y.Length);
        }
    }
}