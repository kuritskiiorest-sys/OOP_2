using System;
using OOP_lab2;

namespace DuelingClubSimulation
{
    public class DuelingClub
    {
        public DuelResult HostDuel(BaseWizard wizard1, BaseWizard wizard2, BaseDuel duel)
        {
            Console.WriteLine($"\n--- {duel.DuelType} між {wizard1.Name} і {wizard2.Name} ---");

            wizard1.ResetHealth();
            wizard2.ResetHealth();

            DuelResult result = new();
            result.Contestants.Add(wizard1);
            result.Contestants.Add(wizard2);

            Random rand = new();

            while (wizard1.Health > 0 && wizard2.Health > 0)
            {
                Spell s1 = wizard1.CastRandomSpell();
                Spell s2 = wizard2.CastRandomSpell();

                if (s1 != null)
                {
                    wizard2.TakeDamage(s1.Damage);
                    result.TurnLog.Add($"{wizard1.Name} -> {s1.Name} ({s1.Damage} dmg). {wizard2.Name}: {wizard2.Health} HP");
                }

                if (wizard2.Health <= 0) break;

                if (s2 != null)
                {
                    wizard1.TakeDamage(s2.Damage);
                    result.TurnLog.Add($"{wizard2.Name} -> {s2.Name} ({s2.Damage} dmg). {wizard1.Name}: {wizard1.Health} HP");
                }
            }

            result.Winner = wizard1.Health > 0 ? wizard1 : wizard2;
            result.Loser = wizard1.Health > 0 ? wizard2 : wizard1;

            duel.ApplyRating(result.Winner, result.Loser);

            wizard1.AddDuelToHistory(result);
            wizard2.AddDuelToHistory(result);

            result.Winner.CelebrateVictory();

            Console.WriteLine($"Переможець: {result.Winner.Name} (Рейтинг: {result.Winner.Rating})");
            Console.WriteLine($"Програв: {result.Loser.Name} (Рейтинг: {result.Loser.Rating})");

            return result;
        }
    }
}