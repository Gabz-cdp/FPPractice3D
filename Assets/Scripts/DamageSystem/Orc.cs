using UnityEngine;

public class Orc : MonoBehaviour, IDamageable
{
    public int health = 100;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Orc took " + amount + " damage. Health now: " + health);
    }
}

