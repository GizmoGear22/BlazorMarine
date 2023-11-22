using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Handlers
{
	public class AttackHandler
	{

		public static double RangeAccuracyAdjuster(IMarine player, IMarine computer)
		{
			var range = FieldManager.DistanceBetweenCharacters(player, computer);
			double RangeAimAdjust = (range + 30) / (2 * range);
			return RangeAimAdjust;
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
