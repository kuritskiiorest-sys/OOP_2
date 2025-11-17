using DuelingClubSimulation;

namespace OOP_lab2
{
    public class GryffindorWizard : BaseWizard
    {
        private bool phoenixUsed = false; // сила працює тільки раз за дуель

        public GryffindorWizard(string name) : base(name, "Гріффіндор") { }

        public override void CelebrateVictory()
        {
            Console.WriteLine($"{Name} вигукує: «Світло завжди переможе темряву!»");
        }

        // СПЕЦІАЛЬНА СИЛА: Хоробрість Фенікса
        // Якщо HP падає нижче 30 – герой миттєво отримує +30 HP (один раз за дуель)
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);

            if (!phoenixUsed && Health < 30 && Health > 0)
            {
                phoenixUsed = true;
                Health += 30;
                if (Health > 100) Health = 100;

                Console.WriteLine($"{Name} активує Хоробрість Фенікса! +30 HP ({Health} HP)");
            }
        }
    }
}