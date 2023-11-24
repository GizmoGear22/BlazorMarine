using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Handlers
{
	public class PlayerStatDistributionHandler
	{
		public static int ChangeAttributeNumberFromStrength(StatsManager.CharacterPrimaryStats stats, StatsManager.CharacterSecondaryStats secStats, ref int originalStrength)
		{

			int NewStrength = stats.Strength;
			if (originalStrength < NewStrength)
			{
				secStats.AttributePoints -= 1;
			}
			else if (originalStrength > NewStrength)
			{
				secStats.AttributePoints += 1;
			}
			originalStrength = NewStrength;
			return secStats.AttributePoints;
		}

		public static int ChangeAttributeNumberFromPerception(StatsManager.CharacterPrimaryStats stats, StatsManager.CharacterSecondaryStats secStats, ref int originalPerception)
		{
            int NewPerception = stats.Perception;
            if (originalPerception < NewPerception)
            {
                secStats.AttributePoints -= 1;
            }
            else if (originalPerception > NewPerception)
            {
                secStats.AttributePoints += 1;
            }
            originalPerception = NewPerception;
            return secStats.AttributePoints;
        }

		public static int ChangeAttributeNumberFromResilience(StatsManager.CharacterPrimaryStats stats, StatsManager.CharacterSecondaryStats secStats, ref int originalResilience)
		{
            int NewResilience = stats.Resilience;
            if (originalResilience < NewResilience)
            {
                secStats.AttributePoints -= 1;
            }
            else if (originalResilience > NewResilience)
            {
                secStats.AttributePoints += 1;
            }
            originalResilience = NewResilience;
            return secStats.AttributePoints;
        }

		public static int ChangeAttributeNumberFromAgility(StatsManager.CharacterPrimaryStats stats, StatsManager.CharacterSecondaryStats secStats, ref int originalAgility)
		{
            int NewAgility = stats.Agility;
            if (originalAgility < NewAgility)
            {
                secStats.AttributePoints -= 1;
            }
            else if (originalAgility > NewAgility)
            {
                secStats.AttributePoints += 1;
            }
            originalAgility = NewAgility;
            return secStats.AttributePoints;
        }
        public static int GetAttributePoints(StatsManager.CharacterSecondaryStats secStats)
        {
            return secStats.AttributePoints;
        }
    }
}
