using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI inventoryText;

    void Update()
    {
        string weapon =
            InventoryManager.instance.hasStoneSword
            ? "Stone Sword"
            : "None";

        inventoryText.text =
            "Wood : " + InventoryManager.instance.wood +
            "\nStone : " + InventoryManager.instance.stone +
            "\nWeapon : " + weapon +
            "\nPress C to Craft";
        string key =
    InventoryManager.instance.hasEscapeKey? "Yes": "No";
    }
}