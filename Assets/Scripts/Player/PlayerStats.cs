using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public int playerHealth;
    public int attackDamage;
    public float attackSpeed;
    public float attackRange;
    public float moveSpeed;

    public void SetStats(int health, int damage, float attackspeed, float range, float speed)
    {
        playerHealth = health;
        attackDamage = damage;
        attackSpeed = attackspeed;
        attackRange = range;
        moveSpeed = speed;
    }

    public void SetHealth(int value)
    {
        playerHealth = value;
    }

    public void SetDamage(int value)
    {
        attackDamage = value;
    }

    public void SetAttackSpeed(float value)
    {
        attackSpeed = value;
    }

    public void SetAttackRange(float value)
    {
        attackRange = value;
    }

    public void SetMovementSpeed(float value)
    {
        moveSpeed = value;
    }
}
