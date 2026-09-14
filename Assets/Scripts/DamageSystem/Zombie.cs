using UnityEngine;

public class Zombie : MonoBehaviour, IDamageable
{
    public int health = 80;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Zombie took " + amount + " damage. Health now: " + health);
    }
}
