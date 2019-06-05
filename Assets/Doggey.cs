public class Doggey
{
    #region
    public string name;
    public float weight;
    public string type;
    public string biosex;
    public string color;
    public int age;
    #endregion

    #region mothod
    public void shout()
    {
        Debug.Log(name + ":Bark");
    }

    public int ConverAge()
    {
        return age * 777;
    }

    public void Eat(string food, string speed = "slow")
    {
        Debug.Log(name + ":" + food + "how fast:" + speed);
    }

    public void Eat(string food, int count)
    {
        Debug.Log(name + ":" + food + "how much" + count);
    }
    #endregion
}
