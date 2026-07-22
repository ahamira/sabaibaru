using UnityEngine;

public class Exit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger!");

        Debug.Log("Inventory : " + InventoryManager.instance);
        Debug.Log("GameManager : " + GameManager.instance);

        if (other.CompareTag("Player") &&
            InventoryManager.instance.hasEscapeKey)
        {
            GameManager.instance.GameClear();
        }
    }
}