namespace OOP_lab2
{
    public class SlytherinWizard : BaseWizard
    {
        private int serpentCurseStacks = 0; // кількість накопичених проклять

        public SlytherinWizard(string name) : base(name, "Слизерин") { }

        public override void CelebrateVictory()
        {
            Console.WriteLine($"{Name} шепоче: «Сила Змії перемогла…» ");
        }
        
        // Кожен наступний удар дає +3 шкоди за кожен стек
        public int ApplySerpentCurseDamage()
        {
            int bonusDamage = serpentCurseStacks * 3;

            // далі прокляття збільшується
            serpentCurseStacks++;

            if (bonusDamage > 0)
            {
                Console.WriteLine($"{Name} активує Прокляття Зміїного Ядра! +{bonusDamage} бонусної шкоди.");
            }

            return bonusDamage;
        }
    }
}