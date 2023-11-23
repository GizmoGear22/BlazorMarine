
using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
	public class AttackManager
	{
		public static void AttackTarget(IMarine shooter, IMarine opponent, ArmorManager.ArmorType type, Random randomNumberSeed)
		{
			var rangeAdjuster = RangeAccuracyAdjuster(shooter, opponent);
			BattleAccuracyCalculation(shooter, opponent, type, rangeAdjuster);
			shooter.CurrentlyEquippedWeapon.DamageDealt(shooter, opponent, randomNumberSeed, type);
		}

		public static double RangeAccuracyAdjuster(IMarine player, IMarine computer)
		{
			var range = FieldManager.DistanceBetweenCharacters(player, computer);
			double RangeAimAdjust = (range + 30.0) / (2.0 * range);
			return RangeAimAdjust;
		}

		public static void BattleAccuracyCalculation(IMarine Shooter, IMarine opponent, ArmorManager.ArmorType target, double Range, double Upgrade = 1)
		{
			var targetAccuracy = ArmorTargetAccuracyHandler(target, opponent);
			var PerceptionBonus = (2 * Shooter.PrimaryStats.Perception) / (2 * Shooter.PrimaryStats.Perception + 5);
			var Aim = PerceptionBonus * Shooter.CurrentlyEquippedWeapon.Accuracy * Upgrade * Range * targetAccuracy * 100;
			Shooter.SecondaryStats.Accuracy = Aim;
		}
		public static double ArmorTargetAccuracyHandler(ArmorManager.ArmorType type, IMarine opponent)
		{
			double target = 0;

			switch (type)
			{
				case ArmorManager.ArmorType.Head:
					target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "Head").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.Torso:
					target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "Torso").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.LeftPauldron:
					target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "LeftPauldron").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.RightPauldron:
					target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "RightPauldron").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.LeftArm:
					target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "LefArm").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.RightArm:
					target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "RightArm").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.LeftLeg:
					target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "LeftLet").Select(x => x.AccuracyModifier).Single();
					break;
				case ArmorManager.ArmorType.RightLeg:
					target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "RightLeg").Select(x => x.AccuracyModifier).Single();
					break;
			}
			return target;
		}
	}
}
