using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int hp = 20;

    public void TakeDamage()
    {
        hp--;

        Debug.Log("Boss HP : " + hp);

        if (hp <= 0)
        {
            InventoryManager.instance.hasEscapeKey = true;

            Debug.Log("Escape Key Obtained!");

            Destroy(gameObject);
        }
    }
}