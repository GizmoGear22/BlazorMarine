namespace ArmoredMarineV2.Managers
{
	public class HelperFunctions
	{
		public static int RandomNumber(int num, Random rnd)
		{
			int GeneratedNumber = rnd.Next(num);
			return GeneratedNumber;
		}

		public static void Shuffle<T>(T[] array, Random _random) //Pulled as Fisher-Yates Shuffle Algorithm. I'll figure out how it works later =/
		{
			int n = array.Length;
			for (int i = 0; i < (n - 1); i++)
			{
				int r = i + _random.Next(n - i);
				(array[i], array[r]) = (array[r], array[i]);
			}
		}
	}
}
