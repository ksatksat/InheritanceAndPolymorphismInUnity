using UnityEngine;

public class Character : MonoBehaviour
{
    public float Health {get; set;}
    public float Damage {get; set;} 
    public string Name {get; set;}
    public virtual string Type {get; set;}
    public virtual void Attack(bool isAttack, Character character) {}
    public string GetName() {return Name + " " + Type;}
    public virtual void TakeDamage(bool didITookDamage) {}
}
