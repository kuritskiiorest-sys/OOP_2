using OOP_lab2;

namespace DuelingClubSimulation
{
    public abstract class BaseDuel
    {
        public abstract int GetRatingStake(); // Скільки рейтинг-балів стоїть на кону
        public abstract string DuelType { get; }

        public abstract void ApplyRating(BaseWizard winner, BaseWizard loser);
    }
}