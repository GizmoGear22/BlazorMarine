using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class ComputerMarineManager : IMarine
    {
        public CharacterPrimaryStats PrimaryStats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CharacterSecondaryStats SecondaryStats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Armor CharacterArmor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeaponsManager.MainWeapons MainWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeaponsManager.SecondaryWeapons SecondaryWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeaponsManager.MeleeWeapons MeleeWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IWeapons CurrentlyEquippedWeapon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CharacterLocation SetCharacterLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
