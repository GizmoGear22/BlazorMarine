using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Handlers
{
	public class PlayerStatDistributionHandler : ICharacterStatDistribution
	{
		public int ChangeAttributeNumberFromStrength(StatsManager.CharacterPrimaryStats stats, StatsManager.CharacterSecondaryStats secStats, int originalStrength)
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

		public int ChangeAttributeNumberFromPerception()
		{
			throw new NotImplementedException();
		}

		public int ChangeAttributeNumberFromResilience()
		{
			throw new NotImplementedException();
		}

		public int ChangeAttributeNumberFromAgility()
		{
			throw new NotImplementedException();
		}
	}
}
