using UnityEngine;
using UnityEngine.Events;

public class CollisionDetection : MonoBehaviour
{
    public UnityEvent collisionEnterEvent, enemyCollisionEvent, playerCollisionEvent, collisionExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        collisionEnterEvent.Invoke();
        EnemyCollision(other);
        PlayerCollision(other);
    }

    private void OnCollisionExit()
    {
        collisionExitEvent.Invoke();
    }

    private void EnemyCollision(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemyCollisionEvent.Invoke();
        }
    }

    private void PlayerCollision(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCollisionEvent.Invoke();
        }
    }
}
