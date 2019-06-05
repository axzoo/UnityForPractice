using UnityEngine;

public class DogManager : MonoBehaviour
{
    #region
    public Doggey DogA = new Doggey();
    public Doggey DogB = new Doggey();
    #endregion


    #region
    private void Start()
    {
    DogA.name = "aaa";
    DogA.weight = 42.3f;
    DogA.type = "shiba";
    DogA.biosex = "male";
    DogA.color = "white";
    DogA.age = 7;

    DogB.name = "bbb";
    DogB.weight = 15.3f;
    DogB.type = "shiba";
    DogB.biosex = "female";
    DogB.color = "brown";
    DogB.age = 3;

    Debug.Log(DogA.name + ":type" + DogA.type + "color:" + DogAcolor);
    Debug.Log(DogB.name + ":type" + DogB.type + "color:" + DogBcolor);

        DogA.Bark();
        DogB.Bark();

        Debug.Log(DogA.name + "actual age:" + DogA.ConvertAge());
        Debug.Log(DogB.name + "actual age:" + DogB.ConvertAge());

        DogA.Eat("coco");
        DogB.Eat("milk", 10);
    }
    #endregion
}