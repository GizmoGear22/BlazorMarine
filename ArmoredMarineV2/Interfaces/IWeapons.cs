namespace ArmoredMarineV2.Interfaces
{
    public interface IWeapons
    {
        double Accuracy { get; }
        int Damage { get; }
        int Cost { get; }
        int ShotsPerRound { get; }
        int Ammo { get; set; }
        double Weight { get; }

        double AccuracyCalculation();
        void DealRangedDamage();
    }
}
