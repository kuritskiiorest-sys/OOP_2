using DuelingClubSimulation;

namespace OOP_lab2
{
    public class DuelResult
    {
        public string DuelId { get; set; }
        public List<BaseWizard> Contestants { get; set; }
        public BaseWizard Winner { get; set; }
        public BaseWizard Loser { get; set; }
        public List<string> TurnLog { get; set; }

        public DuelResult()
        {
            DuelId = Guid.NewGuid().ToString();
            Contestants = new List<BaseWizard>();
            TurnLog = new List<string>();
        }

        public void PrintLog()
        {
            Console.WriteLine($"\n--- Лог дуелі {DuelId} ---");
            foreach (var line in TurnLog)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine($"Переможець: {Winner.Name}, Програв: {Loser.Name}");
        }
    }
}
