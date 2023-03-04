namespace PeopleOop;

public class MainUnit
{
    public static void Test()
    {
        var mage = new Mage(100,30,50);
        var archer = new Archer(60,10,70, 10);
        var knight = new Knight(150,80,10);
        
        mage.TakeDamage(100);
        archer.TakeDamage(60);
        knight.TakeDamage(150);
        
        Unit currentUnit = mage;
        currentUnit.Attack();
        
        currentUnit = archer;
        currentUnit.Attack();
        
        currentUnit = knight;
        currentUnit.Attack();
        
        mage.ShowInfo();
        archer.ShowInfo();
        knight.ShowInfo();




    }
}