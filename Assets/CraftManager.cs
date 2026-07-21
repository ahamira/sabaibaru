using UnityEngine;
using UnityEngine.InputSystem;

public class CraftManager : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            CraftStoneSword();
        }
    }

    void CraftStoneSword()
    {
        if (InventoryManager.instance.hasStoneSword)
        {
            Debug.Log("Already have Stone Sword");
            return;
        }

        if (InventoryManager.instance.wood >= 5 &&
            InventoryManager.instance.stone >= 3)
        {
            InventoryManager.instance.wood -= 5;
            InventoryManager.instance.stone -= 3;

            InventoryManager.instance.hasStoneSword = true;

            Debug.Log("Stone Sword Crafted!");
        }
        else
        {
            Debug.Log("Not enough materials");
        }
    }
}