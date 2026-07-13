using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI inventoryText;

    void Update()
    {
        inventoryText.text =
            "ñÿ : " + InventoryManager.instance.wood +
            "\nêŒ : " + InventoryManager.instance.stone;
    }
}