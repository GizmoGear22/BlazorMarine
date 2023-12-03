using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Handlers
{
    public class StatButton(IMarine HumanPlayer)
    {
        private readonly IMarine _humanPlayer = HumanPlayer;

        public enum StatButtonType
        {
            Strength,
            Agility,
            Resilience,
            Perception
        }

        public int SetInitialStat(StatButtonType type)
        {
            int initialStatValue = 0;
            switch (type)
            {
                case StatButtonType.Strength:
                    initialStatValue = _humanPlayer.PrimaryStats.Strength;
                    break;
                case StatButtonType.Agility:
                    initialStatValue = _humanPlayer.PrimaryStats.Agility;
                    break;
                case StatButtonType.Resilience:
                    initialStatValue = _humanPlayer.PrimaryStats.Resilience;
                    break;
                case StatButtonType.Perception:
                    initialStatValue = _humanPlayer.PrimaryStats.Perception;
                    break;
            }
            return initialStatValue;
        }

        public int ChangeAttributeNumberFromStat(ref int initialStatValue, StatButtonType type)
        {
            int currentStatValue = 0;
            switch (type)
            {
                case StatButtonType.Strength:
                    currentStatValue = _humanPlayer.PrimaryStats.Strength;
                    break; 
                case StatButtonType.Agility:
                    currentStatValue = _humanPlayer.PrimaryStats.Agility;
                    break;
                case StatButtonType.Resilience:
                    currentStatValue = _humanPlayer.PrimaryStats.Resilience;
                    break;
                case StatButtonType.Perception:
                    currentStatValue = _humanPlayer.PrimaryStats.Perception;
                    break;
            }
            if (initialStatValue < currentStatValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints -= 1;

            }
            else if (initialStatValue > currentStatValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints += 1;
            }
            initialStatValue = currentStatValue;
            return _humanPlayer.SecondaryStats.AttributePoints;
        }

    }
}

