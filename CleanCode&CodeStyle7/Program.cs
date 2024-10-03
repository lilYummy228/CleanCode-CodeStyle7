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
    private float _directionHorizontal;
    private float _directionVertical;
    private float _speed;

    public Movement(float directionHorizontal, float directionVertical, float speed)
    {
        _directionHorizontal = directionHorizontal;
        _directionVertical = directionVertical;
        _speed = speed;
    }

    public float DirectionHorizontal => _directionHorizontal;
    public float DirectionVertical => _directionVertical;
    public float Speed => _speed;

    public void Move()
    {
        //Do move
    }
}

public class Weapon
{
    private float _cooldown;
    private int _damage;

    public Weapon(float cooldown, int damage)
    {
        _cooldown = cooldown;
        _damage = damage;
    }

    public float Cooldown => _cooldown;
    public int Damage => _damage;

    public bool IsReloading()
    {
        throw new NotImplementedException();
    }

    public void Attack()
    {        
        //attack
    }
}

