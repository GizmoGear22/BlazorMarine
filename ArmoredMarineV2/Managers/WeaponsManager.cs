using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class WeaponsManager
    {
        public class MainWeapons
        {
            public class BoltRifle : IMainWeapons, IWeapons
            {

                public double Accuracy { get; } = 1;

                public int Damage { get; } = 10;

                public int ShotsPerRound { get; } = 10;

                public int Ammo { get; set; } = 40;

                public double Weight { get; } = 10;

				public int Cost => throw new NotImplementedException();

				public void DamageDealt()
				{
					throw new NotImplementedException();
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


                public void DamageDealt()
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
