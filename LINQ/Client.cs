using System;

namespace LINQ
{
	public class Client
	{
		public Client()
		{
			ClientCode = 0;
			Year = 0;
			Month = 0;
			TimeSpent = 0;
		}

		public int Year { get; set; }

		public int Month { get; set; }

		public double TimeSpent { get; set; }

		public int ClientCode { get; set; }

		public override string ToString()
		{
			var result = "";
			if (ClientCode != 0)
			{
				result += "Client code: " + ClientCode + " ";
			}

			if (Year != 0)
			{
				result += "Year: " + Year + " ";
			}

			if (Month != 0)
			{
				result += "Month: " + Month + " ";
			}

			if (Math.Abs(TimeSpent) > 0.1)
			{
				result += "Time spent: " + TimeSpent + "\n";
			}

			return result;
		}
	}
}