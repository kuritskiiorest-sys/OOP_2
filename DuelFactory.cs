using DuelingClubSimulation;

namespace OOP_lab2
{
    public class DuelFactory
    {
        public BaseDuel CreateTrainingDuel()
        {
            return new TrainingDuel();
        }

        public BaseDuel CreateRankedDuel()
        {
            return new RankedDuel();
        }
    }
}