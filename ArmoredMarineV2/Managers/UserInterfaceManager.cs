using ArmoredMarineV2.DataCode;
using ArmoredMarineV2.Interfaces;
using ArmoredMarineV2.Pages;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ArmoredMarineV2.Managers
{
    public class UserInterfaceManager : IUserInterface
    {
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
        public string GetCombatStats<T>(IMarine HumanPlayer, string message)
        {
            List<string>ShownCombatStats = new List<string>();
            var ArmorList = HumanPlayer.CharacterArmor.ArmorList;
            var Health = HumanPlayer.SecondaryStats.Health;
            var Accuracy = HumanPlayer.SecondaryStats.Accuracy;
            var CurrentEquip = HumanPlayer.CurrentlyEquippedWeapon;
            ShownCombatStats.Add(ArmorList.ToString());
            ShownCombatStats.Add(Health.ToString());
            ShownCombatStats.Add(Accuracy.ToString());
            ShownCombatStats.Add(CurrentEquip.ToString());
            foreach (var item in ShownCombatStats)
            {
                message = $"{item}";
            }

            return message;

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

        public void SetPrimaryStats(StatsManager.CharacterPrimaryStats stats, IMarine HumanPlayer)
        {
            HumanPlayer.PrimaryStats = new StatsManager.CharacterPrimaryStats
            {
                Strength = stats.Strength,
                Agility = stats.Agility,
                Perception = stats.Perception,
                Resilience = stats.Resilience
            };

        }

        public void SetSecondaryStats(StatsManager.CharacterSecondaryStats stats, IMarine HumanPlayer)
        {
            HumanPlayer.SecondaryStats = new StatsManager.CharacterSecondaryStats
            {
                AttributePoints = stats.AttributePoints,
                Credits = stats.Credits,
                ActionPoints = stats.ActionPoints,
                Accuracy = stats.Accuracy,
                Weight = stats.Weight
            };
        }
        public IMarine SetSecondaryWeapon()
        {
            throw new NotImplementedException();
        }

    }
}
