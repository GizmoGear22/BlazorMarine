using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Pages;


namespace ArmoredMarineV2.Managers
{
    public class UserInterfaceManager : IUserInterface
    {
        public Random RandomNumberSeed { get; set; }

		public UserInterfaceManager() { RandomNumberSeed = new Random(); }

		public CombatResults GetCombatResults()
        {
            throw new NotImplementedException();
        }

        public StatsManager GetPrimaryStats()
        {
            throw new NotImplementedException();
        }

        public StatsManager GetSecondaryStats()
        {
            throw new NotImplementedException();
        }

        public AttackModel SetAttackAction()
        {
            throw new NotImplementedException();
        }

        public IMarine SetEquipWeapon()
        {
            throw new NotImplementedException();
        }

        public IMarine SetMainWeapon()
        {
            throw new NotImplementedException();
        }

        public IMarine SetMeleeWeapon()
        {
            throw new NotImplementedException();
        }

        public void SetPrimaryStats(StatsManager.CharacterPrimaryStats stats, IMarine HumanPlayer)
        {
            HumanPlayer.PrimaryStats = new StatsManager.CharacterPrimaryStats();
            HumanPlayer.PrimaryStats.Strength = stats.Strength;
            HumanPlayer.PrimaryStats.Agility = stats.Agility;
            HumanPlayer.PrimaryStats.Perception = stats.Perception;
            HumanPlayer.PrimaryStats.Resilience = stats.Resilience;
            
        }

        public void SetSecondaryStats(StatsManager.CharacterSecondaryStats stats, IMarine HumanPlayer)
        {
            HumanPlayer.SecondaryStats = new StatsManager.CharacterSecondaryStats();
            HumanPlayer.SecondaryStats.AttributePoints = stats.AttributePoints;
            HumanPlayer.SecondaryStats.Credits = stats.Credits;
            HumanPlayer.SecondaryStats.ActionPoints = stats.ActionPoints;
            HumanPlayer.SecondaryStats.Accuracy = stats.Accuracy;
            HumanPlayer.SecondaryStats.Weight = stats.Weight;
        }

        public IMarine SetSecondaryWeapon()
        {
            throw new NotImplementedException();
        }

        public int UseAttributePoints(StatsManager.CharacterSecondaryStats SecondaryStats, int totalDifference)
        {
            return SecondaryStats.AttributePoints -= totalDifference;
        }

    }
}
