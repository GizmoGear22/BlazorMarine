﻿using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Pages;

namespace ArmoredMarineV2.Managers
{
    public class UserInterfaceManager : IUserInterface
    {
        MarineManager HumanPlayer { get; set; }


        public UserInterfaceManager(MarineManager Player)
        {
            HumanPlayer = Player;
        }


        public CombatResults GetCombatResults()
        {
            throw new NotImplementedException();
        }

        public StatsManager GetPrimaryStats()
        {
            throw new NotImplementedException();
        }

        public StatsManager GetSecondaryStats()
        {
            throw new NotImplementedException();
        }

        public AttackModel SetAttackAction()
        {
            throw new NotImplementedException();
        }

        public IMarine SetEquipWeapon()
        {
            throw new NotImplementedException();
        }

        public IMarine SetMainWeapon()
        {
            throw new NotImplementedException();
        }

        public IMarine SetMeleeWeapon()
        {
            throw new NotImplementedException();
        }

        public void SetPrimaryStats(CharacterPrimaryStats stats)
        {
            /*
            HumanPlayer.PrimaryStats.Strength = stats.Strength;
            HumanPlayer.PrimaryStats.Agility = stats.Agility;
            HumanPlayer.PrimaryStats.Perception = stats.Perception;
            HumanPlayer.PrimaryStats.Resilience = stats.Resilience;
            */

        }

        public StatsManager SetSecondaryStats()
        {
            throw new NotImplementedException();
        }

        public IMarine SetSecondaryWeapon()
        {
            throw new NotImplementedException();
        }
    }
}
