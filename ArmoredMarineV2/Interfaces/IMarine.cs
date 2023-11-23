using System;
using ArmoredMarineV2.Managers;
namespace ArmoredMarineV2.Interfaces
{
    public interface IMarine
    {
        StatsManager.CharacterPrimaryStats PrimaryStats { get; set; }
        StatsManager.CharacterSecondaryStats SecondaryStats { get; set; }
        ArmorManager.ArmorSet CharacterArmor { get; set; }
        WeaponsManager.MainWeapons MainWeapon { get; set; }
        WeaponsManager.SecondaryWeapons SecondaryWeapon { get; set; }
        WeaponsManager.MeleeWeapons MeleeWeapon { get; set; }
        IWeapons CurrentlyEquippedWeapon { get; set; }
        FieldManager.CharacterLocation CharacterLocation { get; set; }

        public void ReduceArmor(IMarine attacker, ArmorManager.ArmorType type);
        public void ReduceHealth(IMarine attacker);
        public void SetCharacterLocation();
        public void EquipWeapon(IMarine shooter, IWeapons weapon);
        public void ChangeLocation();
    }
}
