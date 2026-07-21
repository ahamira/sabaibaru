using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 2f;

    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        transform.position =
            Vector2.MoveTowards(
                transform.position,
                player.position,
                moveSpeed * Time.deltaTime
            );
    }
}