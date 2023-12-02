using System.Security.Cryptography.X509Certificates;
using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ArmoredMarineV2.Handlers
{
	public class StrengthStatButtonHandler(IMarine HumanPlayer)
    {
        
        private readonly IMarine _humanPlayer = HumanPlayer;

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

            } else if (initialStrength > strengthValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints += 1;
            }
            initialStrength = strengthValue;
            return _humanPlayer.SecondaryStats.AttributePoints;

        }        
       
    }
}
