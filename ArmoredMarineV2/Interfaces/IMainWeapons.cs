namespace ArmoredMarineV2.Interfaces
{
    public interface IMainWeapons
    {
        double Accuracy { get; }
        int Damage { get; }
        int Cost { get; }
        int ShotsPerRound { get; }
        int Ammo { get; set; }
        double Weight { get; }

		void DamageDealt(IMarine attacker, IMarine opponent);


	}
}
