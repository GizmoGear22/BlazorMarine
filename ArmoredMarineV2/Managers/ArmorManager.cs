using System.Collections;
using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class ArmorManager
    {
        public string Name { get; set; }
        public double ArmorValue { get; set; }
        public double AccuracyModifier { get; set; }

  
        public class Head : IArmor
        {
            public double ArmorValue { get; set; }
            public double ArmorModifier { get; set; } = 0.6;
            public double AccuracyModifier { get; set; } = 0.6;


            public void ConvertResilienceToArmor(StatsManager Resilience)
            {
                throw new NotImplementedException();
            }
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

    }

}
