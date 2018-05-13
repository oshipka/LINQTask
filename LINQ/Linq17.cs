using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
	public class Linq17
	{
		public static void TaskMain()
		{
			var readPath = Misc.SetPath("Task17.txt", true);
			var writePath = Misc.SetPath("Task17.txt", false);
			var taskData = new List<List<int>>();
			Misc.ParseInts(taskData, readPath);
			foreach (var dataLine in taskData)
			{
				var odd = from i in dataLine where i % 2 == 1 select i;
				var noRepeat = odd.Distinct(new Comparer());
				Misc.WriteData(noRepeat, writePath);
			}
		}
	}

	internal class Comparer : IEqualityComparer<int> 
	{
		public bool Equals(int x, int y)
		{
			return x == y;
		}

		public int GetHashCode(int obj)
		{
			return obj.GetHashCode();
		}
	}
}