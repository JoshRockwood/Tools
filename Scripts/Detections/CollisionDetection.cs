using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetection : MonoBehaviour
{
    public UnityEvent collisionEnterEvent, collisionExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        collisionEnterEvent.Invoke();
    }

    private void OnCollisionExit()
    {
        collisionExitEvent.Invoke();
    }
}
