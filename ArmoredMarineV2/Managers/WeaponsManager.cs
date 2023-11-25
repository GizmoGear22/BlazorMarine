using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class WeaponsManager
    {
        public class MainWeapons
        {
            public class BoltRifle : IMainWeapons, IWeapons
            {
                public string Name { get; } = "BoltRifle";

                public double Accuracy { get; } = 1;

                public int Damage { get; } = 10;

                public int ShotsPerRound { get; } = 10;

                public int Ammo { get; set; } = 40;

                public double Weight { get; } = 10;

                public int Cost => throw new NotImplementedException();

                public void DamageDealt(IMarine attacker, IMarine opponent, Random randomNumberSeed, ArmorManager.ArmorType type)
                {
                    double armorDamage = 0.0;
                    double healthDamage = 0.0;
                    var currentArmorValue = opponent.CharacterArmor.ArmorList.Where(x => x.Name == type.ToString()).Select(x => x.ArmorValue).Single();
                    for (int i = 0; i <= attacker.CurrentlyEquippedWeapon.ShotsPerRound; i++)
                    {
                        var shotHitChance = attacker.SecondaryStats.Accuracy;
                        var confirmedHit = HelperFunctions.RandomNumber(100, randomNumberSeed);
                        if (confirmedHit < shotHitChance && currentArmorValue > 0)
                        {
                            opponent.ReduceArmor(attacker, type);
                            armorDamage += attacker.CurrentlyEquippedWeapon.Damage;
                        } else if (confirmedHit < shotHitChance && currentArmorValue <= 0)
                        {
                            currentArmorValue = 0;
                            opponent.ReduceHealth(attacker);
                            healthDamage += attacker.CurrentlyEquippedWeapon.Damage;
                        }
                        attacker.CurrentlyEquippedWeapon.Ammo -= 1;
                    }
                }
            }
            public class AutoBoltRifle : IMainWeapons, IWeapons
            {

                public double Accuracy => throw new NotImplementedException();

                public int Damage => throw new NotImplementedException();

                public int Cost => throw new NotImplementedException();

                public int ShotsPerRound => throw new NotImplementedException();

                public int Ammo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

                public double Weight => throw new NotImplementedException();

				public string Name => throw new NotImplementedException();

				public void DamageDealt(IMarine attacker, IMarine opponent, Random randomNumberSeed, ArmorManager.ArmorType type)
                {
                    throw new NotImplementedException();
                }
            }
        }


        public class SecondaryWeapons
        {
            public class BoltPistol : ISecondaryWeapons, IWeapons
            {
                public double Accuracy => throw new NotImplementedException();

                public int Damage => throw new NotImplementedException();

                public int Cost => throw new NotImplementedException();

                public int ShotsPerRound => throw new NotImplementedException();

                public int Ammo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

                public double Weight => throw new NotImplementedException();

				public string Name => throw new NotImplementedException();

				public void DamageDealt(IMarine attacker, IMarine opponent, Random randomNumberSeed, ArmorManager.ArmorType type)
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

    }
}
