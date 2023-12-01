using System.Security.Cryptography.X509Certificates;
using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ArmoredMarineV2.Handlers
{
	public class PlayerStatButtonHandler
	{
        
        private readonly IMarine _humanPlayer;

        public PlayerStatButtonHandler(IMarine HumanPlayer)
        {
            _humanPlayer = HumanPlayer;
        }

        public int SetStrengthStat()
        {
            return _humanPlayer.PrimaryStats.Strength;
        }
         
        public int ChangeAttributeNumberFromStrength(ref int initialStrength)
         {
            var strengthValue = _humanPlayer.PrimaryStats.Strength;
            if (initialStrength < strengthValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints -= 1;

            } else
            {
                _humanPlayer.SecondaryStats.AttributePoints += 1;
            }
            return _humanPlayer.SecondaryStats.AttributePoints;

            /*var strengthDifference = _humanPlayer.PrimaryStats.Strength - 1;
            _humanPlayer.SecondaryStats.AttributePoints = _humanPlayer.SecondaryStats.MaxAttributePoints - strengthDifference;*/
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
        
        public int GetAttributePoints()
        {
            return _humanPlayer.SecondaryStats.AttributePoints;
        }
    }
}
