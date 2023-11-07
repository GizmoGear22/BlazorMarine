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
        public CharacterLocation SetCharacterLocation { get; set; }

        public MarineManager()
        {

            PrimaryStats = new StatsManager.CharacterPrimaryStats();
            SecondaryStats = new StatsManager.CharacterSecondaryStats();
            CharacterArmor = new ArmorManager.ArmorSet();


        }

        public void EquipWeapon()
        {
            throw new NotImplementedException();
        }

        public void ReduceArmor()
        {
            throw new NotImplementedException();
        }

        public void ReduceHealth()
        {
            throw new NotImplementedException();
        }
    }
}
