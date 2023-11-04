namespace ArmoredMarineV2.Interfaces
{
    public interface IArmor
    {
        double ArmorModifier { get; }
        double AccuracyModifier { get;}

        enum ArmorType
        {
            Head,
            Torso,
            LeftArm,
            RightArm,
            LeftLeg,
            RightLeg
        }

        public void ConvertResilienceToArmor();
    }
}
