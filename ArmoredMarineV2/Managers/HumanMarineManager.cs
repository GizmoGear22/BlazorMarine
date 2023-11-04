using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class HumanMarineManager : IMarine
    {
        public CharacterPrimaryStats PrimaryStats = new CharacterPrimaryStats();
        public CharacterSecondaryStats SecondaryStats = new CharacterSecondaryStats();
        public Armor CharacterArmor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeaponsManager.MainWeapons MainWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeaponsManager.SecondaryWeapons SecondaryWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeaponsManager.MeleeWeapons MeleeWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IWeapons CurrentlyEquippedWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CharacterLocation SetCharacterLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        CharacterPrimaryStats IMarine.PrimaryStats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        CharacterSecondaryStats IMarine.SecondaryStats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
