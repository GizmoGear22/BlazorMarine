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
        }
		
        public void ReduceArmor(IMarine attacker, ArmorManager.ArmorType type)
        {
            var armorValue = CharacterArmor.ArmorList.Where(x => x.Name == type.ToString()).Select(x => x.ArmorValue).Single();
            armorValue -= attacker.CurrentlyEquippedWeapon.Damage;
        
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
            SecondaryStats.AccuracyCalculation(shooter);           
		}

        public void ChangeLocation()
        {
            CharacterLocation.XLocation -= SecondaryStats.MovementDistance;
        }

	}
}
