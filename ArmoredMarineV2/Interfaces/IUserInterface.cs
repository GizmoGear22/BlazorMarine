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
        AttackModel SetAttackAction(IMarine attacker, IMarine defender);
        CombatResults GetCombatResults();
        List<string> GetCombatStats(IMarine HumanPlayer);
        List<string> GetArmorStats(IMarine HumanPlayer);

    }


    public class AttackModel
    {

    }
    public class CombatResults
    {

    }

    public class CharacterLocation
    {
        public int xLocation { get; set; }
        public int yLocation { get; set; }
    }

}
