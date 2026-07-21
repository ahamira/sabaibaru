using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public int wood = 0;
    public int stone = 0;

    public bool hasStoneSword = false;

    void Awake()
    {
        instance = this;
    }


    public void AddItem(string item, int amount)
    {
        if (item == "Wood")
        {
            wood += amount;
            Debug.Log("ñÿçﬁ:" + wood);
        }

        if (item == "Stone")
        {
            stone += amount;
            Debug.Log("êŒ:" + stone);
        }
    }
}