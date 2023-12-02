using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Handlers
{
    public class AgilityStatButtonHandler(IMarine HumanPlayer)
    {
        private readonly IMarine _humanPlayer = HumanPlayer;

        public int SetAgilityStat()
        {
            return _humanPlayer.PrimaryStats.Agility;
        }

        public int ChangeAttributeNumberFromAgility(ref int initialAgility)
        {
            var agilityValue = _humanPlayer.PrimaryStats.Agility;
            if (initialAgility < agilityValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints -= 1;

            }
            else if (initialAgility > agilityValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints += 1;
            }
            initialAgility = agilityValue;
            return _humanPlayer.SecondaryStats.AttributePoints;

        }
    }
}
