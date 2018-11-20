using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
	public class Clock
	{

		public int Minutter1 { get; set; }
		public int Minutter5 { get; set; }
		public int Hour1 { get; set; }
		public int Hour5 { get; set; }


		public Clock(DateTime time)
		{

			// Minutter
			if (time.Minute %5 == 0)
			{
				Minutter5 = time.Minute;
				Minutter1 = 0;

			}
			else
			{
				Minutter1 = time.Minute %5;
				Minutter5 = time.Minute / 5;
			}

			// Timer

			if (time.Hour %5 == 0)
			{
				Hour5 = time.Hour / 5;
				Hour1 = 0;
			}
			else
			{
				Hour1 = time.Hour;
				Hour5 = time.Hour / 5;
			}
		}


		public void UpdateTime(DateTime time)
		{
			if (time.Minute % 5 == 0)
			{
				Minutter5 = time.Minute / 5;
				Minutter1 = 0;
			}
			else
			{
				Minutter1 = time.Minute %5;
				Minutter5 = time.Minute / 5;
			}

			if (time.Hour % 5 == 0)
			{
				Hour5 = time.Hour / 5;
				Hour1 = 0;
			}
			else
			{
				Hour1 = time.Hour %5;
				Hour5 = time.Hour / 5;
			}

		}
	}
}
