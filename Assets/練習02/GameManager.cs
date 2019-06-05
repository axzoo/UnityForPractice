using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Soldier SoliderA = new Soldier();
    public Warrior WarriorA = new Warrior();

    private void Start()
    {
        SoliderA.LV = 42;
        Debug.Log("solider EXP - GET:" + SoliderA.GetExp());

        SoliderA.SetExp(2107);
        Debug.Log("solider EXP - SET:" + SoliderA.Exp);

        WarriorA.lv = 42;
        Debug.Log("warrior EXP - GET:" + WarriorA.Exp);

        WarriorA.Exp = 421;
        Debug.Log("warrior EXP - SET:" + WarriorA.Exp);
    }


}
