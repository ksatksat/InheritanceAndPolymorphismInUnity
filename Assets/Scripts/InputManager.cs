using UnityEngine;

public class InputManager : MonoBehaviour
{
    //bool isOrcAttacks = false;
    public bool OrcAttacks()
    {
        ///if (Input.GetButtonDown("Q"))
        ///{
        ///    isOrcAttacks = true;
        ///    Debug.Log("orcAttacks = true");
        ///}
        ///else if (Input.GetButtonUp("Q"))
        ///{
        ///    isOrcAttacks = false;
        ///    Debug.Log("orcAttacks = false");
        ///}
        ///if (Input.GetKeyDown(KeyCode.Q))
        ///{
        ///    isOrcAttacks = true;
        ///    Debug.Log("orcAttacks = true");
        ///}
        ///else if (Input.GetKeyUp(KeyCode.Q))
        ///{
        ///    isOrcAttacks = false;
        ///    Debug.Log("orcAttacks = false");
        ///}
        ///all those constructions not implement  call of "attack" method once
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
