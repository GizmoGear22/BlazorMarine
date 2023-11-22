using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Handlers
{
	public class SecondaryStatsHandler
	{
		public static void AccuracyCalculation(IMarine Shooter, double Upgrade = 1)
		{
			var PerceptionBonus = (2 * Shooter.PrimaryStats.Perception) / (2 * Shooter.PrimaryStats.Perception + 5);
			var Aim = PerceptionBonus * Shooter.CurrentlyEquippedWeapon.Accuracy * Upgrade * 100;

			Shooter.SecondaryStats.Accuracy = Aim;
		}
		public static void AccuracyCalculation(IMarine Shooter, IMarine opponent, ArmorManager.ArmorType target, double Range, double Upgrade = 1)
		{
			var targetAccuracy = AttackHandler.ArmorTargetAccuracyHandler(target, opponent);
			var PerceptionBonus = (2 * Shooter.PrimaryStats.Perception) / (2 * Shooter.PrimaryStats.Perception + 5);
			var Aim = PerceptionBonus * Shooter.CurrentlyEquippedWeapon.Accuracy * Upgrade * Range * targetAccuracy * 100;
			Shooter.SecondaryStats.Accuracy = Aim;
		}

		public static void WeightCalculation(IMarine player) //Will need to make a pattern for this. Having to do overloads here
		{
			double ArmorWeight = 0;
			foreach (var pieces in player.CharacterArmor.ArmorList)
			{
				ArmorWeight += pieces.ArmorValue / 0.65;
			}
			player.SecondaryStats.Weight = ArmorWeight;
		}
	}
}
