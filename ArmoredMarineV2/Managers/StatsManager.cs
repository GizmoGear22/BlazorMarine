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
        }

    }
}
