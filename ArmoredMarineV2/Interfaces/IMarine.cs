﻿using System;
using ArmoredMarineV2.Managers;
namespace ArmoredMarineV2.Interfaces
{
    public interface IMarine
    {
        StatsManager.CharacterPrimaryStats PrimaryStats { get; set; }
        StatsManager.CharacterSecondaryStats SecondaryStats { get; set; }
        ArmorManager CharacterArmor { get; set; }
        WeaponsManager.MainWeapons MainWeapon { get; set; }
        WeaponsManager.SecondaryWeapons SecondaryWeapon { get; set; }
        WeaponsManager.MeleeWeapons MeleeWeapon { get; set; }
        IWeapons CurrentlyEquippedWeapon { get; set; }
        CharacterLocation SetCharacterLocation { get; set; }

        public void EquipWeapon();
        public void ReduceArmor();
        public void ReduceHealth();

    }
}