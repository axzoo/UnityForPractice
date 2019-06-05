using UnityEngine;

public class GameManager : MonoBehaviour
{
    public soilder SoliderA = new soilder();

    private void Start()
    {
        SoliderA.LV = 42;
        Debug.Log("solider EXP - GET:" + SoliderA.GetExp());

        SoliderA.SetExp(2107);
        Debug.Log("solider EXP - SET:" + SoliderA.Exp);
    }


}
