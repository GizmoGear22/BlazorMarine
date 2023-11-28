namespace ArmoredMarineV2.Handlers
{
	public class CombatButtonHandler
	{
		public static void CombatButtonSwitch(ref bool OnOffSwitch)
		{
			if (OnOffSwitch == false)
			{
				OnOffSwitch = true;
			}
			else if (OnOffSwitch == true)
			{
				OnOffSwitch = false;
			}
		}
	}
}
