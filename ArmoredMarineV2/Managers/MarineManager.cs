using System.Net.NetworkInformation;
using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class MarineManager : IMarine
    {
        public StatsManager.CharacterPrimaryStats PrimaryStats { get; set; }
        public StatsManager.CharacterSecondaryStats SecondaryStats { get; set; }
        public ArmorManager.ArmorSet CharacterArmor { get; set; }
        public WeaponsManager.MainWeapons MainWeapon { get; set; }
        public WeaponsManager.SecondaryWeapons SecondaryWeapon { get; set; }
        public WeaponsManager.MeleeWeapons MeleeWeapon { get; set; }
        public IWeapons CurrentlyEquippedWeapon { get; set; }
		public FieldManager.CharacterLocation CharacterLocation { get ; set ; }

		public MarineManager()
        {
            CharacterArmor = new ArmorManager.ArmorSet();
            PrimaryStats = new StatsManager.CharacterPrimaryStats();
            SecondaryStats = new StatsManager.CharacterSecondaryStats();
        }
		
        public void ReduceArmor(IMarine attacker, ArmorManager.ArmorType type)
        {
            /*
            var armorValue = CharacterArmor.ArmorList.Where(x => x.Name == type.ToString()).Select(x => x.ArmorValue).Single();
            armorValue = Convert.ToInt32(armorValue);
            armorValue -= attacker.CurrentlyEquippedWeapon.Damage; //problem is here. LINQ is ready-only. Have to find a way to change value another way.*/

            switch (type) //Is there a way to do this with LINQ for readability?
            {
                case ArmorManager.ArmorType.Head:
                    CharacterArmor.ArmorList[0].ArmorValue -= attacker.CurrentlyEquippedWeapon.Damage;
                    break;
                case ArmorManager.ArmorType.Torso:
					CharacterArmor.ArmorList[1].ArmorValue -= attacker.CurrentlyEquippedWeapon.Damage;
                    break;
				case ArmorManager.ArmorType.LeftPauldron:
					CharacterArmor.ArmorList[2].ArmorValue -= attacker.CurrentlyEquippedWeapon.Damage;
					break;
				case ArmorManager.ArmorType.RightPauldron:
					CharacterArmor.ArmorList[3].ArmorValue -= attacker.CurrentlyEquippedWeapon.Damage;
					break;
				case ArmorManager.ArmorType.LeftArm:
					CharacterArmor.ArmorList[4].ArmorValue -= attacker.CurrentlyEquippedWeapon.Damage;
					break;
				case ArmorManager.ArmorType.RightArm:
					CharacterArmor.ArmorList[5].ArmorValue -= attacker.CurrentlyEquippedWeapon.Damage;
					break;
				case ArmorManager.ArmorType.LeftLeg:
					CharacterArmor.ArmorList[6].ArmorValue -= attacker.CurrentlyEquippedWeapon.Damage;
					break;
				case ArmorManager.ArmorType.RightLeg:
					CharacterArmor.ArmorList[7].ArmorValue -= attacker.CurrentlyEquippedWeapon.Damage;
					break;
			}

        }
        public void ReduceHealth(IMarine attacker)
        {
            SecondaryStats.Health -= attacker.CurrentlyEquippedWeapon.Damage;
        }

		public void SetCharacterLocation()
		{
            CharacterLocation = new FieldManager.CharacterLocation(50, 50);
		}

        public void EquipWeapon(IMarine shooter, IWeapons weapon)
        {
			CurrentlyEquippedWeapon = weapon;
            StatsManager.CharacterSecondaryStats.StartingStatAccuracyCalculation(shooter);           
		}

        public void ChangeLocation()
        {
            CharacterLocation.XLocation -= SecondaryStats.MovementDistance;
        }

	}
}
