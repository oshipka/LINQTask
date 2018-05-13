using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
	public class Linq44
	{
		public static void TaskMain()
		{
			var readPath = Misc.SetPath("Task44.txt", true);
			var writePath = Misc.SetPath("Task44.txt", false);
			var taskData = new List<List<int>>();
			Misc.ParseInts(taskData, readPath);
			if (taskData.Count % 3 != 0)
			{
				throw new InvalidDataException($"Not enough data, count = {taskData.Count}");
			}
			for (var k =2; k<taskData.Count; k+=3)
			{
				var K1 = taskData[k - 2][0];
				var K2 = taskData[k - 2][1];

				var numbers = taskData[k - 1].
					Where(x => x > K1).
					Concat(taskData[k].
						Where(x => x < K2)).
					OrderBy(x=>x);
				
				Misc.WriteData(numbers, writePath);
			}
		}
	}
}