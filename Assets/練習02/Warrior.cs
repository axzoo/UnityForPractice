[System.Serializable]

public class Warrior
{
    public int exp;
    public int lv;

    public int Exp
    {
        get
        {
            exp = lv * 25;
            return exp;
        }
        set
        {
            exp = value;
        }
    }
}