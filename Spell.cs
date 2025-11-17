namespace OOP_lab2
{
    public enum SpellEffect
    {
        Disarming,
        Stunning,
        Damage
    }

    public class Spell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public SpellEffect Effect { get; set; }

        public Spell(string name, int damage, SpellEffect effect)
        {
            Name = name;
            Damage = damage;
            Effect = effect;
        }
    }
}