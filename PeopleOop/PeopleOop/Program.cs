namespace PeopleOop;

public abstract class Unit
{
    protected int Damage;
    protected int Armor;
    protected int Health;
    
    public abstract void Attack();

    protected Unit(int health, int armor, int damage)
    {
        Health = health;
        Armor = armor;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage - Armor;
    }

    public void ShowInfo()
    {
        Console.WriteLine(Health);
    }
}