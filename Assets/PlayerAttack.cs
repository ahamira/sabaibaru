using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public float attackRange = 1.5f;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Attack();
        }
    }


    void Attack()
    {
        Collider2D[] hits =
            Physics2D.OverlapCircleAll(
                transform.position,
                attackRange
            );


        foreach (Collider2D hit in hits)
        {
            ResourceNode resource =
                hit.GetComponent<ResourceNode>();

            if (resource != null)
            {
                resource.TakeDamage();
            }
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(
            transform.position,
            attackRange
        );
    }
}