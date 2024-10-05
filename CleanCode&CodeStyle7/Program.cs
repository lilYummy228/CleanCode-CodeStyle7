using System;

namespace CleanCode_CodeStyle7
{
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

        public void Move() => 
            _movement.Move();

        public bool IsReloading() => 
            _weapon.IsReloading();

        public void Attack() => 
            _weapon.Attack();
    }

    public class Movement
    {
        public Movement(float directionHorizontal, float directionVertical, float speed)
        {
            DirectionHorizontal = directionHorizontal > 0 ? directionHorizontal : throw new ArgumentOutOfRangeException(nameof(directionHorizontal));
            DirectionVertical = directionVertical > 0 ? directionVertical : throw new ArgumentOutOfRangeException(nameof(directionVertical));
            Speed = speed >= 0 ? speed : throw new ArgumentOutOfRangeException(nameof(speed));
        }

        public float DirectionHorizontal { get; }
        public float DirectionVertical { get; }
        public float Speed { get; }

        public void Move()
        {
            //Do move
        }
    }

    public class Weapon
    {
        public Weapon(float cooldown, int damage)
        {
            Cooldown = cooldown > 0 ? cooldown : throw new ArgumentOutOfRangeException(nameof(cooldown));
            Damage = damage > 0 ? damage : throw new ArgumentOutOfRangeException(nameof(damage));
        }

        public float Cooldown { get; }
        public int Damage { get; }

        public bool IsReloading()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            //attack
        }
    }
}