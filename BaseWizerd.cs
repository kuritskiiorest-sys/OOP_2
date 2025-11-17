namespace OOP_lab2
{
    public abstract class BaseWizard
    {
        private const int InitialHealth = 100;

        public string Name { get; set; }
        public string House { get; set; }
        public int Health { get; protected set; }
        public int Rating { get; set; } = 1000;
        public List<Spell> KnownSpells { get; private set; }
        protected List<DuelResult> duelHistory;

        protected BaseWizard(string name, string house)
        {
            Name = name;
            House = house;
            Health = InitialHealth;
            KnownSpells = new List<Spell>();
            duelHistory = new List<DuelResult>();
        }

        public void LearnSpell(Spell spell) => KnownSpells.Add(spell);

        public virtual Spell CastRandomSpell()
        {
            if (KnownSpells.Count == 0) return null;
            Random rand = new Random();
            return KnownSpells[rand.Next(KnownSpells.Count)];
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public void ResetHealth() => Health = InitialHealth;

        public void AddDuelToHistory(DuelResult duel) => duelHistory.Add(duel);

        public void PrintDuelHistory()
        {
            Console.WriteLine($"\nІсторія дуелей {Name}:");
            foreach (var duel in duelHistory)
            {
                Console.WriteLine($"  Переможець: {duel.Winner.Name}, Програв: {duel.Loser.Name}");
            }
        }

        // Абстрактний метод
        public abstract void CelebrateVictory();
    }
}