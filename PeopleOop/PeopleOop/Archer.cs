namespace PeopleOop
{
    public class Archer : Unit
    {
        public Archer( int health, int armor, int damage, int attackSpeed) : base(health, armor, damage * attackSpeed) {}
        
        public void Eye()
        {
            Health -= 20;
            Damage += 30;
        }
        
        public override void Attack()
        {
            Console.WriteLine($"The archer shoots more accurate arrows: ");
        }
    }
}