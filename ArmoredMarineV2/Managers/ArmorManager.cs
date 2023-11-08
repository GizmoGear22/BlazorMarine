using System.Collections;
using ArmoredMarineV2.Interfaces;
using System.Linq;

namespace ArmoredMarineV2.Managers
{
    public class ArmorManager
    {
        public class ArmorSet
        {
            public List<ArmorPieces> ArmorList { get; set; }
            public ArmorSet() 
            {
                ArmorList = new List<ArmorPieces>
                {
                new ArmorPieces {Name = "Head", ArmorValue = 0.6, AccuracyModifier = 0.6},
                new ArmorPieces {Name = "Torso", ArmorValue = 1.3, AccuracyModifier = 1.2},
                new ArmorPieces {Name = "LeftPauldron", ArmorValue = 1.1, AccuracyModifier = 1},
                new ArmorPieces {Name = "RightPauldron", ArmorValue = 1.1, AccuracyModifier= 1},
                new ArmorPieces {Name = "LeftArm", ArmorValue = 0.8, AccuracyModifier = 0.8},
                new ArmorPieces {Name = "RightArm", ArmorValue = 0.8, AccuracyModifier = 0.8},
                new ArmorPieces {Name = "LeftLeg", ArmorValue = 0.8, AccuracyModifier = 0.8},
                new ArmorPieces {Name = "RightLeg", ArmorValue = 0.8, AccuracyModifier = 0.8}
                };
            }
         
            public void ResilienceToArmor(IMarine marine)

            {
                foreach (ArmorPieces piece in marine.CharacterArmor.ArmorList)
                {
                    piece.ArmorValue = piece.ArmorValue * marine.PrimaryStats.Resilience * 10;
                }

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

