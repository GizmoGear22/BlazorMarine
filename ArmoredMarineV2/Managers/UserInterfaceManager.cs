
using ArmoredMarineV2.Handlers;
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
        public List<string> GetCombatStats(IMarine HumanPlayer)
        {
            List<string>ShownCombatStats = new List<string>();


            var Health = HumanPlayer.SecondaryStats.Health;
            var Accuracy = HumanPlayer.SecondaryStats.Accuracy;
            var CurrentEquip = HumanPlayer.CurrentlyEquippedWeapon;
            ShownCombatStats.Add("Health");
            ShownCombatStats.Add(Health.ToString());
            ShownCombatStats.Add("Accuracy");
            ShownCombatStats.Add(Accuracy.ToString());
            //ShownCombatStats.Add(CurrentEquip.ToString());

            return ShownCombatStats;
        }

        public List<string> GetArmorStats(IMarine HumanPlayer)
        {
			List<string> ShownArmorStats = new List<string>();
			var ArmorList = HumanPlayer.CharacterArmor.ArmorList;
			foreach (var armor in ArmorList)
			{
				ShownArmorStats.Add($"{armor.Name}: {armor.ArmorValue}");
			}

            return ShownArmorStats;
		}

        public void SetAttackAction(IMarine shooter, IMarine opponent, ArmorManager.ArmorType type, Random randomNumberSeed)
        {
            //What should this method do?
            //Should bundle all the necessary methods to attack into here. 
            var rangeAdjuster = AttackHandler.RangeAccuracyAdjuster(shooter, opponent);
            SecondaryStatsHandler.AccuracyCalculation(shooter, opponent, type, rangeAdjuster);
            shooter.CurrentlyEquippedWeapon.DamageDealt(shooter, opponent, randomNumberSeed, type);

            /*
            IEnumerable<double> target;
            switch (Type)
            {
                case ArmorManager.ArmorType.Head:
                    target = opponent.CharacterArmor.ArmorList.Where(x => x.Name == "Head").Select(x => x.ArmorValue);
                    break;		
			}
			var range = FieldManager.DistanceBetweenCharacters(player, opponent);
			double AccuracyRangeComponent = (range + 30) / (2 * range);
			throw new NotImplementedException();
            */
            
        }

        public void SetEquipWeapon(IMarine player, IWeapons weapon)
        {
            player.CurrentlyEquippedWeapon = weapon;
            player.SecondaryStats.AccuracyCalculation(player);
        }

        public void SetEquipWeapon(IMarine player, IMarine opponent, IWeapons weapon)
        {
            player.CurrentlyEquippedWeapon = weapon;
        }

        public IMarine SetMainWeapon(IMarine player, IMainWeapons weapon)
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

		public void ChangeLocation(IMarine player)
		{
            player.CharacterLocation.XLocation -= player.SecondaryStats.MovementDistance;
		}
	}
}
