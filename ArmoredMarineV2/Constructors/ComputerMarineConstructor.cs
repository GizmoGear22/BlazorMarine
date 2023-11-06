using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Managers;

namespace ArmoredMarineV2.Constructors
{
    public class ComputerMarineConstructor
    {
        private readonly IMarine _marine;
        public ComputerMarineConstructor(MarineManager ComputerPlayer)
        {
            _marine = ComputerPlayer;
        }

        public void AllocateStats()
        {

        }
    }


}
