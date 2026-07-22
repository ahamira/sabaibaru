using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public float damageInterval = 0.5f;

    private float timer;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
            return;

        timer += Time.deltaTime;

        if (timer >= damageInterval)
        {
            collision.gameObject
                .GetComponent<PlayerStatus>()
                .TakeDamage(damage);

            timer = 0f;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timer = 0f;
        }
    }
}