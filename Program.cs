using DuelingClubSimulation;

namespace OOP_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Spell expelliarmus = new Spell("Експеліармус", 15, SpellEffect.Disarming);
            Spell stupefy = new Spell("Ступефай", 20, SpellEffect.Stunning);
            Spell petrificus = new Spell("Петрифікус Тоталус", 25, SpellEffect.Damage);

            var harry = new GryffindorWizard("Гаррі Поттер");
            var draco = new SlytherinWizard("Драко Мелфой");

            harry.LearnSpell(expelliarmus);
            harry.LearnSpell(stupefy);

            draco.LearnSpell(stupefy);
            draco.LearnSpell(petrificus);

            var club = new DuelingClub();
            var factory = new DuelFactory();

            var training = factory.CreateTrainingDuel();
            var ranked = factory.CreateRankedDuel();

            club.HostDuel(harry, draco, training);
            club.HostDuel(harry, draco, ranked);

            harry.PrintDuelHistory();
            draco.PrintDuelHistory();
        }
    }
}