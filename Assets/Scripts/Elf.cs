using UnityEngine;

public class Elf : Character, IFriendshipContract
{
    public override string Type { get {return "Elf";} }
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
        character.Health += this.Health;
        character.Damage += this.Damage;
        Debug.Log($"Now {character.GetName()} and {this.GetName()} are friends");
        Debug.Log($"Now {character.GetName()} health is : {character.Health}");
        Debug.Log($"Now {character.GetName()} damage is : {character.Damage}");
    }
}
