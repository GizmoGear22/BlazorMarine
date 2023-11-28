using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Handlers
{
	public class PlayerStatButtonHandler
	{
        public readonly IMarine _humanPlayer;
            public PlayerStatButtonHandler(IMarine HumanPlayer)
        {
            _humanPlayer = HumanPlayer;
        }

        
        public int ChangeAttributeNumberFromStrength()
        {
            var strengthDifference = _humanPlayer.PrimaryStats.Strength - 1;
            _humanPlayer.SecondaryStats.AttributePoints = _humanPlayer.SecondaryStats.MaxAttributePoints - strengthDifference;

            return _humanPlayer.SecondaryStats.AttributePoints;
        }

		public int ChangeAttributeNumberFromPerception()
		{
            var perceptionDifference = _humanPlayer.PrimaryStats.Perception - 1;
            _humanPlayer.SecondaryStats.AttributePoints = _humanPlayer.SecondaryStats.MaxAttributePoints - perceptionDifference;

            return _humanPlayer.SecondaryStats.AttributePoints;
        }

		public int ChangeAttributeNumberFromResilience()
		{
            var resilienceDifference = _humanPlayer.PrimaryStats.Resilience - 1;
            _humanPlayer.SecondaryStats.AttributePoints = _humanPlayer.SecondaryStats.MaxAttributePoints - resilienceDifference;

            return _humanPlayer.SecondaryStats.AttributePoints;
        }

		public int ChangeAttributeNumberFromAgility()
		{
            var agilityDifference = _humanPlayer.PrimaryStats.Agility - 1;
            _humanPlayer.SecondaryStats.AttributePoints = _humanPlayer.SecondaryStats.MaxAttributePoints - agilityDifference;

            return _humanPlayer.SecondaryStats.AttributePoints;
        }
        public int GetAttributePoints(IMarine player)
        {
            return player.SecondaryStats.AttributePoints;
        }
    }
}
