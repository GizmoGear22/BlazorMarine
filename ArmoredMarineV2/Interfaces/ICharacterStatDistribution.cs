using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Interfaces
{
	public interface ICharacterStatDistribution
	{
		int ChangeAttributeNumberFromStrength(StatsManager.CharacterPrimaryStats stats, StatsManager.CharacterSecondaryStats secStats, int originalStrength);
		int ChangeAttributeNumberFromAgility();
		int ChangeAttributeNumberFromResilience();
		int ChangeAttributeNumberFromPerception();
	}
}
