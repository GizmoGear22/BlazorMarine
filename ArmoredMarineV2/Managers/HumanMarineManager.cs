using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class HumanMarineManager : IMarine
    {
        public CharacterPrimaryStats PrimaryStats { get; set; }
        public CharacterSecondaryStats SecondaryStats { get; set; }
        public Armor CharacterArmor { get; set; }
        public WeaponsManager.MainWeapons MainWeapon { get; set; }
        public WeaponsManager.SecondaryWeapons SecondaryWeapon { get; set; }
        public WeaponsManager.MeleeWeapons MeleeWeapon { get; set; }
        public IWeapons CurrentlyEquippedWeapon { get; set; }
        public CharacterLocation SetCharacterLocation { get; set; }

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
