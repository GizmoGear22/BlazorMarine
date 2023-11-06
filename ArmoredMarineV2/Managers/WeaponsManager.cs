using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class WeaponsManager
    {
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

				public void DamageDealt()
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

                public void DamageDealt()
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

                public void DamageDealt()
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
