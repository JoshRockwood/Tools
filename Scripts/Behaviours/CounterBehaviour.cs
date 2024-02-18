using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CounterBehaviour : MonoBehaviour
{
   public UnityEvent startEvent, repeatEvent, endEvent;

   public IntData counterNum;
   public float seconds = 3.0f;
   private WaitForSeconds wfsObj;

   IEnumerator Start()
   {
    wfsObj = new WaitForSeconds(seconds);
    startEvent.Invoke();
    yield return wfsObj;

    while (counterNum.value > 0)
    {
        repeatEvent.Invoke();
        counterNum.value--;
        yield return wfsObj;
    }

    endEvent.Invoke();
   }
}

