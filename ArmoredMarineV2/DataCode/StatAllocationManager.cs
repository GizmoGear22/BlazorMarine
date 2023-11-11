using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;
using MudBlazor.Extensions;

namespace ArmoredMarineV2.DataCode

{
    public class StatAllocationManager
    {
        private readonly IUserInterface _userInterface;
        private readonly IMarine _humanPlayer;
        public StatAllocationManager(IUserInterface userInterface, IMarine humanPlayer)
        {
            this._userInterface = userInterface;
            this._humanPlayer = humanPlayer;
        }

        public int ReduceAttributeStatNumber()
        {
            return _humanPlayer.SecondaryStats.AttributePoints--;
        }
        public int GainAttributeStatNumber()
        {
            return _humanPlayer.SecondaryStats.AttributePoints++;
        }
        public void ManageAttributeStats(int initialStatValue, int finalValue)
        {
            if (initialStatValue > finalValue)
            {
                ReduceAttributeStatNumber();
            } 
            else if (initialStatValue < finalValue)
            {
                GainAttributeStatNumber();
            }
        }

    


        public enum StatType 
        {
            Strength,
            Agility,
            Resilience,
            Perception
        }

    }
}
