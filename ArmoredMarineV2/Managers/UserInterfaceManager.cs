using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Pages;


namespace ArmoredMarineV2.Managers
{
    public class UserInterfaceManager : IUserInterface
    {
        IMarine HumanPlayer { get; set; }


        public UserInterfaceManager(IMarine Player)
        {
            HumanPlayer = Player;
        }


        public CombatResults GetCombatResults()
        {
            throw new NotImplementedException();
        }

        public StatsManager GetPrimaryStats()
        {
            throw new NotImplementedException();
        }

        public StatsManager GetSecondaryStats()
        {
            throw new NotImplementedException();
        }

        public AttackModel SetAttackAction()
        {
            throw new NotImplementedException();
        }

        public IMarine SetEquipWeapon()
        {
            throw new NotImplementedException();
        }

        public IMarine SetMainWeapon()
        {
            throw new NotImplementedException();
        }

        public IMarine SetMeleeWeapon()
        {
            throw new NotImplementedException();
        }

        public void SetPrimaryStats(StatsManager.CharacterPrimaryStats stats)
        {
            
            HumanPlayer.PrimaryStats.Strength = stats.Strength;
            HumanPlayer.PrimaryStats.Agility = stats.Agility;
            HumanPlayer.PrimaryStats.Perception = stats.Perception;
            HumanPlayer.PrimaryStats.Resilience = stats.Resilience;
            
        }

        public void SetSecondaryStats(StatsManager.CharacterSecondaryStats stats)
        {
            HumanPlayer.SecondaryStats.Credits = stats.Credits;
            HumanPlayer.SecondaryStats.ActionPoints = stats.ActionPoints;
            HumanPlayer.SecondaryStats.AttributePoints = stats.AttributePoints;
            HumanPlayer.SecondaryStats.Accuracy = stats.Accuracy;
        }

        public IMarine SetSecondaryWeapon()
        {
            throw new NotImplementedException();
        }
    }
}
