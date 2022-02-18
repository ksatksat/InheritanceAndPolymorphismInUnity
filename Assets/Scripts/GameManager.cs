using UnityEngine;

public class GameManager : MonoBehaviour
{
    Orc orc;
    public GameObject orcGO;
    Human human;
    public GameObject humanGO;
    Elf elf;
    public GameObject elfGO;
    InputManager inputManager;
    public GameObject inputManagerGO;
    bool isOrcAttacks, isHumanAttacks, isEveryoneAttacked, isFriendshipDeclared;
    bool isElfFoundFriend = false;
    int orcOrHuman;
    private void Awake() 
    {
        orc = orcGO.GetComponent<Orc>();
        orc.Name = "Urukhai";
        orc.Health = 173f;
        orc.Damage = 24f;
        human = humanGO.GetComponent<Human>();
        human.Name = "Boromir";
        human.Health = 96f;
        human.Damage = 13f;
        elf = elfGO.GetComponent<Elf>();
        elf.Name = "Legolas";
        elf.Health = 100f;
        elf.Damage = 36f;
        inputManager = inputManagerGO.GetComponent<InputManager>();
    }
    void Start()
    {
        Debug.Log(orc.GetName());
        Debug.Log(human.GetName());
        Debug.Log(elf.GetName());
    }

    void Update()
    {
        OrcAttacking();
        HumanAttacking();
        AttackEveryone();
        MakeFriendsFromTwoSides();
    }
    void OrcAttacking()
    {
        this.isOrcAttacks = inputManager.OrcAttacks();
        if (!this.isOrcAttacks)
        {
            return;
        }
        if (orc.Health <= 0f)
        {
            Debug.Log($"{orc.GetName()} can't attack because his dead !");
            return;
        }
        orc.Attack(this.isOrcAttacks, human);
    }
    void HumanAttacking()
    {
        this.isHumanAttacks = inputManager.HumanAttacks();
        if (!this.isHumanAttacks)
        {
            return;
        }
        if (human.Health <= 0f)
        {
            Debug.Log($"{human.GetName()} can't attack because his dead !");
            return;
        }
        human.Attack(this.isHumanAttacks, orc);
    }
    void AttackEveryone()
    {
        Character[] everyOne = {orc, human, elf};
        isEveryoneAttacked = inputManager.AttackEveryone();
        foreach (var item in everyOne)
        {
            if (!isEveryoneAttacked)
            {
                return;
            }
            if (item.Health <= 0f)
            {
                Debug.Log($"{item.GetName()} can't take damage anymore because his dead !");
                return;
            }
            item.TakeDamage(isEveryoneAttacked);
        }
    }
    void MakeFriendsFromTwoSides()
    {
        if (isElfFoundFriend)//makes elf friend to someone only once
        {
            return;
        }
        isFriendshipDeclared = inputManager.MakeFriends();
        if (!isFriendshipDeclared)
        {
            return;
        }
        orcOrHuman = Random.Range(1,3);//random will decide with whom elf become friends
        switch (orcOrHuman)
        {
            case 1:
            elf.MakeTwoSidesFriends(orc);
            break;
            case 2:
            elf.MakeTwoSidesFriends(human);
            break;
        }
        isElfFoundFriend = true;//makes elf friend to someone only once
    }
}
