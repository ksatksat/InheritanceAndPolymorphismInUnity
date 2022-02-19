using UnityEngine;

public class Orc : Character, IFriendshipContract
{
    public Orc(string _name, float _health, float _damage)
    {
        Name = _name;
        Health = _health;
        Damage = _damage;
    }
    public override string Type {get => "Orc";}
    public override void Attack(bool isAttack, Character character)
    {
        if (!isAttack)
        {
            return;
        }
        if (character.Health <= 0f)
        {
            Debug.Log($"{character.GetName()} is already dead");
            return;
        }
        Debug.Log($"{this.GetName()} attacks!");
        character.Health -= Damage;
        Debug.Log($"{character.GetName()} health is :{character.Health}");
    }
    public override void TakeDamage(bool didITookDamage)
    {
        if (!didITookDamage)
        {
            return;
        }
        if (this.Health <= 0f)
        {
            return;
        }
        Debug.Log($"{this.GetName()} took damage!");
        this.Health -= 8f;
        Debug.Log($"{this.GetName()} health is :{this.Health}");
    }
    public void MakeTwoSidesFriends(Character character)
    {
        Debug.Log($"{this.GetName()} can't make friend request to {character.GetName()}, because his way too much proud, but can accept friendship");
    }
}
