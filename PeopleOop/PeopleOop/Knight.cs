namespace PeopleOop
{
    public class Knight : Unit
    {
        public Knight( int health, int armor, int damage) : base(health, armor, damage) {}
        
        public void Shield()
        {
            Armor += 100;
            Health += 100;
        }
        
        public override void Attack()
        {
            Console.WriteLine($"Just a shield: ");
        }
    }
}