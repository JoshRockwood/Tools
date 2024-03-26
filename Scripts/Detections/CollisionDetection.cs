using UnityEngine;
using UnityEngine.Events;

public class CollisionDetection : MonoBehaviour
{
    public UnityEvent collisionEnterEvent, enemyCollisionEvent, playerCollisionEvent, collisionExitEvent;
    private bool hasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        collisionEnterEvent.Invoke();
        EnemyCollision(other);
        PlayerCollision(other);
    }

    private void OnCollisionExit()
    {
        collisionExitEvent.Invoke();
        hasCollided = false;
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
        if (other.CompareTag("Player") && !hasCollided)
        {
            playerCollisionEvent.Invoke();
            hasCollided = true;
        }
    }
}
