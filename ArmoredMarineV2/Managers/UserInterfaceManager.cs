using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Pages;
using Microsoft.AspNetCore.Components;

namespace ArmoredMarineV2.Managers
{
    public class UserInterfaceManager : IUserInterface
    {
        public Random RandomNumberSeed { get; set; }

		public UserInterfaceManager() { RandomNumberSeed = new Random(); }

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

        public void SetPrimaryStats(StatsManager.CharacterPrimaryStats stats, IMarine HumanPlayer)
        {
            HumanPlayer.PrimaryStats = new StatsManager.CharacterPrimaryStats
            {
                Strength = stats.Strength,
                Agility = stats.Agility,
                Perception = stats.Perception,
                Resilience = stats.Resilience
            };

        }

        public void SetSecondaryStats(StatsManager.CharacterSecondaryStats stats, IMarine HumanPlayer)
        {
            HumanPlayer.SecondaryStats = new StatsManager.CharacterSecondaryStats
            {
                AttributePoints = stats.AttributePoints,
                Credits = stats.Credits,
                ActionPoints = stats.ActionPoints,
                Accuracy = stats.Accuracy,
                Weight = stats.Weight
            };
        }
        public IMarine SetSecondaryWeapon()
        {
            throw new NotImplementedException();
        }

    }
}
