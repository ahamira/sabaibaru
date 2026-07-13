using UnityEngine;

public class ResourceNode : MonoBehaviour
{
    public string resourceName = "Wood";
    public int amount = 1;

    public int hp = 3;

    public void TakeDamage()
    {
        hp--;

        Debug.Log(resourceName + "‚ğUŒ‚ HP:" + hp);

        if (hp <= 0)
        {
            InventoryManager.instance.AddItem(resourceName, amount);
            Destroy(gameObject);
        }
    }
}