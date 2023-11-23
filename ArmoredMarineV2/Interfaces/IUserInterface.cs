using ArmoredMarineV2.Managers;
using Microsoft.AspNetCore.Components;

namespace ArmoredMarineV2.Interfaces
{
    public interface IUserInterface
    {
		StatsManager GetPrimaryStats();
        StatsManager GetSecondaryStats();
        void SetPrimaryStats(IMarine humanPlayer, StatsManager.CharacterPrimaryStats newStats);
        void SetSecondaryStats(StatsManager.CharacterSecondaryStats stats, IMarine HumanPlayer);
        IMarine SetMainWeapon(IMarine player, IMainWeapons weapon);
        IMarine SetSecondaryWeapon();
        IMarine SetMeleeWeapon();
        void SetEquipWeapon(IMarine player, IWeapons weapon);
        void SetAttackAction(IMarine shooter, IMarine opponent, ArmorManager.ArmorType type, Random randomNumberSeed);
        CombatResults GetCombatResults();
        List<string> GetCombatStats(IMarine HumanPlayer);
        List<string> GetArmorStats(IMarine HumanPlayer);
        void SetNewLocation(IMarine player);
    }


    public class AttackModel
    {

    }
    public class CombatResults
    {

    }



}
