using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int hp = 3;

    public void TakeDamage()
    {
        hp--;

        Debug.Log("Enemy HP : " + hp);

        if (hp <= 0)
        {
            InventoryManager.instance.stone += 2;

            Debug.Log("Stone +2");

            Destroy(gameObject);
        }
    }
}