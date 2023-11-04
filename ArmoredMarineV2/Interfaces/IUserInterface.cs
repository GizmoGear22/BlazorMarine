namespace ArmoredMarineV2.Interfaces
{
    interface IUserInterface
    {
        CharacterModel GetPrimaryStats();
        CharacterModel GetSecondaryStats();
        CharacterModel SetPrimaryStats();
        CharacterModel SetMainWeapon();
        CharacterModel SetSecondaryWeapon();
        CharacterModel SetMeleeWeapon();
        CharacterModel SetEquipWeapon();
        AttackModel SetAttackAction();

    }

    public class CharacterModel
    {
        CharacterPrimaryStats PrimaryStats { get; set; }
        CharacterSecondaryStats SecondaryStats { get; set; }
        Armor CharacterArmor { get; set; }
        MainWeapons MainWeapon { get; set; }
        SecondaryWeapons SecondaryWeapon { get; set; }
        MeleeWeapons MeleeWeapons { get; set; }
        IWeapons CurrentlyEquippedWeapon { get; set; }

    }

    public class CharacterPrimaryStats
    {
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Resilience { get; set; }
        public int Perception { get; set; }
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

    public class CharacterLocation
    {
        public int xLocation { get; set; }
        public int yLocation { get; set; }
    }

    public class MainWeapons
    {
        public class BoltRifle : IWeapons
        {

            public double Accuracy => throw new NotImplementedException();

            public int Damage => throw new NotImplementedException();

            public int Cost => throw new NotImplementedException();

            public int ShotsPerRound => throw new NotImplementedException();

            public int Ammo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public double Weight => throw new NotImplementedException();

            public double AccuracyCalculation()
            {
                throw new NotImplementedException();
            }

            public void DealRangedDamage()
            {
                throw new NotImplementedException();
            }
        }
        public class AutoBoltRifle : IWeapons
        {

            public double Accuracy => throw new NotImplementedException();

            public int Damage => throw new NotImplementedException();

            public int Cost => throw new NotImplementedException();

            public int ShotsPerRound => throw new NotImplementedException();

            public int Ammo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public double Weight => throw new NotImplementedException();

            public double AccuracyCalculation()
            {
                throw new NotImplementedException();
            }

            public void DealRangedDamage()
            {
                throw new NotImplementedException();
            }
        }
    }

    public class SecondaryWeapons
    {
        public class BoltPistol : IWeapons
        {
            public double Accuracy => throw new NotImplementedException();

            public int Damage => throw new NotImplementedException();

            public int Cost => throw new NotImplementedException();

            public int ShotsPerRound => throw new NotImplementedException();

            public int Ammo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public double Weight => throw new NotImplementedException();

            public double AccuracyCalculation()
            {
                throw new NotImplementedException();
            }

            public void DealRangedDamage()
            {
                throw new NotImplementedException();
            }
        }
    }

    public class MeleeWeapons
    {
        public class ChainSword
        {

        }
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

        /*
        public class Head
        {
            public double ArmorModifier = 0.6;
            public double AccuracyModifier = 0.6;

        }
        public class Torso
        {
            public double ArmorModifier = 1.3;
            public double AccuracyModifier = 1.2;

        }
        public class LeftPauldron
        {
            public double ArmorModifier = 1.1;
            public double AccuracyModifier = 1;

        }
        public class RightPauldron 
        {
            public double ArmorModifier = 1.1;
            public double AccuracyModifier = 1;
        }
        public class LeftArm
        {
            public double ArmorModifier = 0.8;
            public double AccuracyModifier = 0.8;
        }
        public class RightAarm
        {
            public double ArmorModifier = 0.8;
            public double AccuracyModifier = 0.8;
        }
        public class LeftLeg
        {
            public double ArmorModifier = 0.8;
            public double AccuracyModifier = 0.8;
        }
        public class RightLeg
        {
            public double ArmorModifier = 0.8;
            public double AccuracyModifier = 0.8;
        }
        */
    }
}
