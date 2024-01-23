using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction action;
    public UnityEvent startEvent, respondEvent, respondLateEvent, runInAnimatorEvent;
    public float holdTime = 0.1f;
    private WaitForSeconds waitobj;
    public UnityAction raise;

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        waitobj = new WaitForSeconds(holdTime);
        action.raiseNoArgs += Respond;
    }

    private void Respond()
    {
        respondEvent.Invoke();
        StartCoroutine(RespondLate());
    }

    private IEnumerator RespondLate()
    {
        yield return waitobj;
        respondLateEvent.Invoke();
    }

    private void RunFromAnimator()
    {
        runInAnimatorEvent.Invoke();
    }

    private void OnDestroy()
    {
        action.raiseNoArgs = null;
    }

    public void RaiseAction()
    {
        raise?.Invoke();
    }

}
