using System;

public class Player
{
    private Movement _movement;
    private Weapon _weapon;
    private string _name;
    private int _age;       

    public Player(Movement movement, Weapon weapon, string name, int age)
    {
        _movement = movement ?? throw new ArgumentNullException(nameof(movement));
        _weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
        _name = name != string.Empty ? name : throw new ArgumentNullException(nameof(name));
        _age = age > 0 ? age : throw new ArgumentOutOfRangeException(nameof(age));
    }

}

public class Movement
{
    public float DirectionHorizontal { get; private set; }

    public float DirectionVertical { get; private set; }

    public float Speed { get; private set; }

    public void Move()
    {
        //Do move
    }
}

public class Weapon
{
    public float Cooldown { get; private set; }

    public int Damage { get; private set; }

    public bool IsReloading()
    {
        throw new NotImplementedException();
    }

    public void Attack()
    {        
        //attack
    }
}

