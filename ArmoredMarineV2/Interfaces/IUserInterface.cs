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
        IMarine SetMainWeapon();
        IMarine SetSecondaryWeapon();
        IMarine SetMeleeWeapon();
        IMarine SetEquipWeapon();
        AttackModel SetAttackAction();
        CombatResults GetCombatResults();

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
