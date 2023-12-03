
using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
	public class AttackManager
	{
		public static void AttackTarget(IMarine shooter, IMarine opponent, ArmorManager.ArmorType type, Random randomNumberSeed)
		{
			var rangeAdjuster = RangeAccuracyConversion(shooter, opponent);
			BattleAccuracyCalculation(shooter, opponent, type, rangeAdjuster);
			shooter.CurrentlyEquippedWeapon.DamageDealt(shooter, opponent, randomNumberSeed, type);
		}

		public static double RangeAccuracyConversion(IMarine player, IMarine computer) //Will need to rename these adjusters to conversions for clarity
		{
			var range = FieldManager.DistanceBetweenCharacters(player, computer);
			double rangeAimAdjust = (range + 30.0) / (2.0 * range);
			return rangeAimAdjust;
		}

		public static void BattleAccuracyCalculation(IMarine shooter, IMarine opponent, ArmorManager.ArmorType target, double Range, double Upgrade = 1)
		{
			var armorTargetAccuracy = ArmorTargetAccuracyHandler(target, opponent);
			var perceptionBonus = (2.0 * shooter.PrimaryStats.Perception) / (2.0 * shooter.PrimaryStats.Perception + 5.0);
			var totalAccuracy = perceptionBonus * shooter.CurrentlyEquippedWeapon.Accuracy * Upgrade * Range * armorTargetAccuracy * 100.0;
			shooter.SecondaryStats.Accuracy = totalAccuracy;
		}
		public static double ArmorTargetAccuracyHandler(ArmorManager.ArmorType type, IMarine opponent)
		{
			double targetAccuracyModifier = 0;

			switch (type)
			{
				case ArmorManager.ArmorType.Head:
					targetAccuracyModifier = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "Head").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.Torso:
					targetAccuracyModifier = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "Torso").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.LeftPauldron:
					targetAccuracyModifier = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "LeftPauldron").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.RightPauldron:
					targetAccuracyModifier = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "RightPauldron").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.LeftArm:
					targetAccuracyModifier = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "LefArm").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.RightArm:
					targetAccuracyModifier = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "RightArm").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.LeftLeg:
					targetAccuracyModifier = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "LeftLeg").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.RightLeg:
					targetAccuracyModifier = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "RightLeg").Select(x => x.AccuracyModifier).Single();
					break;
			}
			return targetAccuracyModifier;
		}
	}
}
