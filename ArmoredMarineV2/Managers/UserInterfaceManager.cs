using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Pages;

namespace ArmoredMarineV2.Managers
{
    public class UserInterfaceManager : IUserInterface
    {
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

		MarineManager IUserInterface.SetPrimaryStats(MarineManager player, StatsManager.CharacterPrimaryStats stats)
        {
            player.PrimaryStats.Strength = stats.Strength;
            player.PrimaryStats.Agility = stats.Agility;
            player.PrimaryStats.Perception = stats.Perception;
            player.PrimaryStats.Resilience = stats.Resilience;

            return player;

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
