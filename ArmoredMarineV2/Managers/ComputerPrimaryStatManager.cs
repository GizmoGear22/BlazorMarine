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

		public static int[] RandomstatsArray(Random RandomNumberSeed)
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
		public static void AssignIndividualComputerStats(MainStats stat, int[] statsArray, MarineManager computerMarine)
		{
			switch (stat)
			{
				case MainStats.Strength:
					computerMarine.PrimaryStats.Strength += statsArray[0];
					break;
				case MainStats.Agility:
					computerMarine.PrimaryStats.Agility += statsArray[1];
					break;
				case MainStats.Resilience:
					computerMarine.PrimaryStats.Resilience += statsArray[2];
					break;
				case MainStats.Perception:
					computerMarine.PrimaryStats.Perception += statsArray[3];
					break;
			}

		}
		
	}
}
