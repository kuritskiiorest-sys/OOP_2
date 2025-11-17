using OOP_lab2;

namespace DuelingClubSimulation
{
    public class TrainingDuel : BaseDuel
    {
        public override int GetRatingStake() => 0;
        public override string DuelType => "Тренувальна дуель";

        public override void ApplyRating(BaseWizard winner, BaseWizard loser)
        {
            // Без змін у рейтингу
        }
    }
}