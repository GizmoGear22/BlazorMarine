using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
	public class ComputerMarineConstructor
	{
		private IMarine _marine;
		public ComputerMarineConstructor(MarineManager ComputerPlayer)
		{
			_marine = ComputerPlayer;	
		}

		public void AllocateStats()
		{
		
		}
	}


}
