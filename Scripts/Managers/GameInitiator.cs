using UnityEngine;
using UnityEngine.Events;

public class GameInitiator : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent;

    void Awake()
    {
        awakeEvent.Invoke();
    }
    void Start()
    {
        startEvent.Invoke();
    }
}
