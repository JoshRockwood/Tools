using UnityEngine;
using UnityEngine.Events;

public class HealthDataTracker : MonoBehaviour
{
    public HealthBar healthBar;

    public void Start()
    {
        healthBar.InitializeHealth();
    }

    public void TakeDamage(int damage)
    {
        healthBar.TakeDamage(damage);
    }
}