using ArmoredMarineV2.Managers;
using Microsoft.AspNetCore.Components;

namespace ArmoredMarineV2.Interfaces
{
    public interface IUserInterface
    {
		StatsManager GetPrimaryStats();
        StatsManager GetSecondaryStats();
        void SetPrimaryStats(StatsManager.CharacterPrimaryStats stats, IMarine player);
        void SetSecondaryStats(StatsManager.CharacterSecondaryStats stats, IMarine player);
        IMarine SetMainWeapon(IMarine player, IMainWeapons weapon);
        IMarine SetSecondaryWeapon();
        IMarine SetMeleeWeapon();
        void SetEquipWeapon(IMarine player, IWeapons weapon);
        void SetEquipWeapon(IMarine player, IMarine opponent, IWeapons weapon);
        void SetAttackAction(IMarine attacker, IMarine defender, ArmorManager.ArmorType type, Random randomNumberSeed);
        CombatResults GetCombatResults();
        List<string> GetCombatStats(IMarine HumanPlayer);
        List<string> GetArmorStats(IMarine HumanPlayer);
        void ChangeLocation(IMarine player);
    }


    public class AttackModel
    {

    }
    public class CombatResults
    {

    }



}
