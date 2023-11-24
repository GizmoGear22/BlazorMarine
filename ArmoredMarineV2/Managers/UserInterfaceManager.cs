

using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Pages;
using Microsoft.AspNetCore.Components;
using MudBlazor;

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
        public List<string> GetCombatStats(IMarine HumanPlayer)
        {
            return StatsManager.CharacterSecondaryStats.ListCombatStats(HumanPlayer);
        }

        public List<string> GetArmorStats(IMarine HumanPlayer)
        {
            return HumanPlayer.CharacterArmor.ArmorStats(HumanPlayer);
		}

        public void SetAttackAction(IMarine shooter, IMarine opponent, ArmorManager.ArmorType type, Random randomNumberSeed)
        {
            AttackManager.AttackTarget(shooter, opponent, type, randomNumberSeed);
        }

        public void SetEquipWeapon(IMarine player, IWeapons weapon)
        {
            player.EquipWeapon(player, weapon);
        }

        public IMarine SetMainWeapon(IMarine player, IMainWeapons weapon)
        {
            throw new NotImplementedException();
        }

        public IMarine SetMeleeWeapon()
        {
            throw new NotImplementedException();
        }

        public StatsManager.CharacterPrimaryStats SetPrimaryStats(IMarine humanPlayer, StatsManager.CharacterPrimaryStats newStats)
        {
            return StatsManager.CharacterPrimaryStats.PrimaryStatAllocation(humanPlayer, newStats);
        }

        public void SetSecondaryStats(StatsManager.CharacterSecondaryStats stats, IMarine HumanPlayer)
        {
            stats.SecondaryStatAllocation(HumanPlayer, stats);
        }

        public IMarine SetSecondaryWeapon()
        {
            throw new NotImplementedException();
        }

		public void SetNewLocation(IMarine player)
		{
            player.ChangeLocation();
		}
	}
}
