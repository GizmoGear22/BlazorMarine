using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Interfaces
{
    public interface IArmor
    {
        double ArmorModifier { get; }
        double AccuracyModifier { get;}
        int ArmorValue { get; set; }

        enum ArmorType
        {
            Head,
            Torso,
            LeftArm,
            RightArm,
            LeftLeg,
            RightLeg
        }

        public void ConvertResilienceToArmor(StatsManager Resilience);
    }
}
