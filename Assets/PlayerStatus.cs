using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int maxHP = 10;

    private int currentHP;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        Debug.Log("Player HP : " + currentHP);

        if (currentHP <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        GameManager.instance.GameOver();
    }

    public int GetHP()
    {
        return currentHP;
    }
}