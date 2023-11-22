using System;
using System.Security.Cryptography;
using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
	public class ComputerPrimaryStatManager
	{
		public enum MainStats
		{
			Strength,
			Agility,
			Resilience,
			Perception
		}

		public static int[] RandomStatsArray(Random RandomNumberSeed)
		{

			var statPointsAvailable = 30;
			int[] statStorage = new int[4];
			for (int i = 0; i < 4; i++)
			{
				var stat = HelperFunctions.RandomNumber(10, RandomNumberSeed);
				var currentStatTotal = statPointsAvailable;
				statPointsAvailable -= stat;
				if (statPointsAvailable <= 0)
				{
					stat = currentStatTotal;
				}
				statStorage[i] = stat;
			}
			HelperFunctions.Shuffle(statStorage, RandomNumberSeed);
			return statStorage;
		}
		public static void AssignIndividualComputerStats(MainStats stat, int[] StatsArray, MarineManager computerMarine)
		{
			switch (stat)
			{
				case MainStats.Strength:
					computerMarine.PrimaryStats.Strength += StatsArray[0];
					break;
				case MainStats.Agility:
					computerMarine.PrimaryStats.Agility += StatsArray[1];
					break;
				case MainStats.Resilience:
					computerMarine.PrimaryStats.Resilience += StatsArray[2];
					break;
				case MainStats.Perception:
					computerMarine.PrimaryStats.Perception += StatsArray[3];
					break;
			}

		}
		
	}
}
