namespace ArmoredMarineV2.Managers
{
    public class StatsManager
    {
        public class CharacterPrimaryStats
        {
            public int Strength { get; set; }
            public int Agility { get; set; }
            public int Resilience { get; set; }
            public int Perception { get; set; }
        }
        public class CharacterSecondaryStats 
        {
            public double Accuracy { get; set; }
            public double Weight { get; set; }
            public int ActionPoints { get; set; } = 2;
            public int MovementDistance { get; set; }
        }

    }
}
