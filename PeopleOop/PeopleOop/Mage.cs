namespace PeopleOop
{
    public class Mage : Unit
    {
        public Mage( int health, int armor, int damage) : base(health, armor, damage) {}

        public void Explosion()
        {
            Damage += 1000;
            Health -= 99;
        }
        
        public override void Attack()
        {
            Console.WriteLine($"A magician reads a spell: ");
        }
        
    }
}