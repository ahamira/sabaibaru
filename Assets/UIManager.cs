using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI inventoryText;
    public TextMeshProUGUI hpText;

    PlayerStatus player;

    void Start()
    {
        player = FindFirstObjectByType<PlayerStatus>();
    }

    void Update()
    {
        string weapon =
            InventoryManager.instance.hasStoneSword
            ? "Stone Sword"
            : "None";

        inventoryText.text =
            "Wood : " + InventoryManager.instance.wood +
            "\nStone : " + InventoryManager.instance.stone +
            "\nWeapon : " + weapon;

        hpText.text =
            "HP : " + player.GetHP();
    }
}