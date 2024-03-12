using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class HealthBar : ScriptableObject
{
    public int maxHealth;
    public int currentHealth;
    public UnityEvent onValueChanged, onHealthZero;

    public void InitializeHealth()
    {
        currentHealth = maxHealth;
        onValueChanged.Invoke();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        onValueChanged.Invoke();
        if (currentHealth <= 0)
        {
            onHealthZero.Invoke();
        }
    }
}
