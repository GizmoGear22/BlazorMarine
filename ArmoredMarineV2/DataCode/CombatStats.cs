using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.DataCode
{
	public class CombatStats
	{
		public List<ArmorManager.ArmorPieces> ArmorSet { get; set; }
		public int Health { get; set; }
		public double Accuracy { get; set; }
		public int MovementDistance { get; set; }


		private readonly IMarine _HumanPlayer;
		public CombatStats(IMarine HumanPlayer)
		{
			_HumanPlayer = HumanPlayer;
			ArmorSet = _HumanPlayer.CharacterArmor.ArmorList;
			Health = _HumanPlayer.SecondaryStats.Health;
			Accuracy = _HumanPlayer.SecondaryStats.Accuracy;
			MovementDistance = _HumanPlayer.SecondaryStats.MovementDistance;
			var CurrentlyEquippedWeapon = _HumanPlayer.CurrentlyEquippedWeapon;

		}

	

			
	}
}
