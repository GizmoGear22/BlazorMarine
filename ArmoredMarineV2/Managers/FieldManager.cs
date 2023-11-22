using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Pages;

namespace ArmoredMarineV2.Managers
{
	public class FieldManager
	{
		public class CharacterLocation
		{	
			public int XLocation { get; set; }
			public int YLocation { get; set; }

			public CharacterLocation(int x, int y) {  XLocation = x; YLocation = y;}

		}

		public static int DistanceBetweenCharacters(IMarine player, IMarine computer)
		{
			int distanceApart = player.CharacterLocation.XLocation + computer.CharacterLocation.XLocation;
			return distanceApart;

		}
	}
}
