using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Handlers
{
    public class ResilienceStatButtonHandler(IMarine HumanPlayer)
    {
        private readonly IMarine _humanPlayer = HumanPlayer;

        public int SetResilienceStat()
        {
            return _humanPlayer.PrimaryStats.Resilience;
        }

        public int ChangeAttributeNumberFromResilience(ref int initialResilience)
        {
            var resilienceValue = _humanPlayer.PrimaryStats.Resilience;
            if (initialResilience < resilienceValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints -= 1;

            }
            else if (initialResilience > resilienceValue)
            {
                _humanPlayer.SecondaryStats.AttributePoints += 1;
            }
            initialResilience = resilienceValue;
            return _humanPlayer.SecondaryStats.AttributePoints;
        }
    }
}
