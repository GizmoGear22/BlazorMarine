using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Handlers
{
    public class PerceptionStatButtonHandler(IMarine HumanPlayer)
    {
        private readonly IMarine _humanPlayer = HumanPlayer;

        public int SetPerceptionStat()
        {
            return _humanPlayer.PrimaryStats.Perception;
        }

        public int ChangeAttributeNumberFromSPerception(ref int initialPerception)
        {
            var perceptionValue = _humanPlayer.PrimaryStats.Perception;
            if (initialPerception < perceptionValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints -= 1;

            }
            else if (initialPerception > perceptionValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints += 1;
            }
            initialPerception = perceptionValue;
            return _humanPlayer.SecondaryStats.AttributePoints;
        }
    }
}
