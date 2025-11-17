using DuelingClubSimulation;

namespace OOP_lab2
{
    public class RankedDuel : BaseDuel
    {
        public override int GetRatingStake() => 50;
        public override string DuelType => "Рейтинговий поєдинок";

        public override void ApplyRating(BaseWizard winner, BaseWizard loser)
        {
            winner.Rating += GetRatingStake();
            loser.Rating -= GetRatingStake();
        }
    }
}