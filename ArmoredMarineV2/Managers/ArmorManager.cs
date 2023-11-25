using System.Collections;
using ArmoredMarineV2.Interfaces;
using System.Linq;

namespace ArmoredMarineV2.Managers
{
    public class ArmorManager
    {

        public enum ArmorType
        {
            Head,
            Torso,
            LeftPauldron,
            RightPauldron,
            LeftArm,
            RightArm,
            LeftLeg,
            RightLeg,
        }

        public class ArmorSet
        {
            public List<ArmorPieces> ArmorList { get; set; }
            public ArmorSet() 
            {
                ArmorList = new List<ArmorPieces>
                {
                new() {Name = "Head", ArmorValue = 0.6, AccuracyModifier = 0.6},
                new() {Name = "Torso", ArmorValue = 1.3, AccuracyModifier = 1.2},
				new()  {Name = "LeftPauldron", ArmorValue = 1.1, AccuracyModifier = 1},
				new()  {Name = "RightPauldron", ArmorValue = 1.1, AccuracyModifier= 1},
				new()  {Name = "LeftArm", ArmorValue = 0.8, AccuracyModifier = 0.8},
				new()  {Name = "RightArm", ArmorValue = 0.8, AccuracyModifier = 0.8},
				new()  {Name = "LeftLeg", ArmorValue = 0.8, AccuracyModifier = 0.8},
				new()  {Name = "RightLeg", ArmorValue = 0.8, AccuracyModifier = 0.8}
                };
            }
         
            public void ResilienceToArmor(IMarine marine)

            {
                foreach (ArmorPieces piece in marine.CharacterArmor.ArmorList)
                {
                    piece.ArmorValue = Math.Floor(piece.ArmorValue * marine.PrimaryStats.Resilience * 10);
                }

            }

            public List<string> ArmorStats(IMarine player)
            {
				List<string> ShownArmorStats = new();
				var ArmorList = player.CharacterArmor.ArmorList;
				foreach (var armor in ArmorList)
				{
					ShownArmorStats.Add($"{armor.Name}: {armor.ArmorValue}");
				}

				return ShownArmorStats;
			}

            

        }
        public class ArmorPieces : IArmor
        {
            public string Name { get; set; }
            public double ArmorValue { get; set; }
            public double AccuracyModifier { get; set; }

			
        }

    }
}

