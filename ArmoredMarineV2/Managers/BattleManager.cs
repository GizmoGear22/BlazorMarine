namespace ArmoredMarineV2.Managers
{
	public class BattleManager
	{
		public static bool GoFirst(Random RandomNumberSeed)
		{
			bool playerFirst = false;
			int ChanceToDetermine = RandomNumberSeed.Next(100);
			if (ChanceToDetermine <= 50)
			{
				return playerFirst = true;
			}
			else
			{
				return playerFirst = false;
			}
		}
	}
}
