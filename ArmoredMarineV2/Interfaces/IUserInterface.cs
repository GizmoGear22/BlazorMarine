using ArmoredMarineV2.Managers;
namespace ArmoredMarineV2.Interfaces
{
    public interface IUserInterface
    {
        StatsManager GetPrimaryStats();
        StatsManager GetSecondaryStats();
        void SetPrimaryStats(StatsManager.CharacterPrimaryStats stats);
        void SetSecondaryStats(StatsManager.CharacterSecondaryStats stats);
        IMarine SetMainWeapon();
        IMarine SetSecondaryWeapon();
        IMarine SetMeleeWeapon();
        IMarine SetEquipWeapon();
        AttackModel SetAttackAction();
        CombatResults GetCombatResults();

    }

    public class CharacterSecondaryStats 
    {
        public double Accuracy { get; set; }
        public double Weight { get; set; }
        public int ActionPoints { get; set; } = 2;

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



    public class Armor
    {
        public double ArmorModifier { get; set; }
        public double AccuracyModifier { get; set; }

        public enum ArmorType
        {
            Head,
            Torso,
            LeftArm,
            RightArm,
            LeftLeg,
            RightLeg
        }

        

       
    }
}
