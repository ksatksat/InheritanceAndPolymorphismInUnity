using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool OrcAttacks()
    {
        return Input.GetKeyDown(KeyCode.Q);
    }
    public bool HumanAttacks()
    {
        return Input.GetKeyDown(KeyCode.E);
    }
    public bool AttackEveryone()
    {
        return Input.GetKeyDown(KeyCode.W);
    }
    public bool MakeFriends()
    {
        return Input.GetKeyDown(KeyCode.R);
    }
}
