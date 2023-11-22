using System.ComponentModel.DataAnnotations;
using ArmoredMarineV2.Handlers;
using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class StatsManager
    {

        public class CharacterPrimaryStats
        {
            public int Strength { get; set; } = 1;
            public int Agility { get; set; } = 1;
            public int Resilience { get; set; } = 1;
            public int Perception { get; set; } = 1;

        }
        public class CharacterSecondaryStats 
        {
            public double Accuracy { get; set; }
            public double Weight { get; set; }
            public int ActionPoints { get; set; } = 2;
            public int MovementDistance { get; set; }
            public int Credits { get; set; }
            public int AttributePoints { get; set; } = 30;
            public int Health { get; set; } = 100;

            public void AccuracyCalculation(IMarine Shooter, double Upgrade = 1)
            {
                var PerceptionBonus = (2 * Shooter.PrimaryStats.Perception) / (2 * Shooter.PrimaryStats.Perception + 5);
                var Aim = PerceptionBonus * Shooter.CurrentlyEquippedWeapon.Accuracy * Upgrade;

                Accuracy = Aim;
            }
			public void AccuracyCalculation(IMarine Shooter, IMarine opponent, ArmorManager.ArmorType target, double Range, double Upgrade = 1)
			{
                var targetAccuracy = AttackHandler.ArmorTargetAccuracyHandler(target, opponent);
				var PerceptionBonus = (2 * Shooter.PrimaryStats.Perception) / (2 * Shooter.PrimaryStats.Perception + 5);
                var Aim = PerceptionBonus * Shooter.CurrentlyEquippedWeapon.Accuracy * Upgrade * Range * targetAccuracy;
				Accuracy = Aim;
			}

			public void WeightCalculation(List<ArmorManager.ArmorPieces> List) //Will need to make a pattern for this. Having to do overloads here
            {
                double ArmorWeight = 0;
                foreach (var pieces in List)
                {
                    ArmorWeight += pieces.ArmorValue / 0.65;
                }
                Weight = ArmorWeight;
            }

            public void WeightCalculation(List<ArmorManager.ArmorPieces> List, IMainWeapons weapon) 
            {
                double ArmorWeight = 0;
                foreach (var pieces in List)
                {
                    ArmorWeight += pieces.ArmorValue / 0.65;
                }
                Weight = ArmorWeight + weapon.Weight;
            }

            public void PossibleMovementDistance(IMarine character)
            {
                var weightToMove = Weight / 11;
                var agilityToMove = character.PrimaryStats.Agility * 10 + 10;
                MovementDistance = (int)Math.Floor(agilityToMove / weightToMove);
            }

        }





    }
}
