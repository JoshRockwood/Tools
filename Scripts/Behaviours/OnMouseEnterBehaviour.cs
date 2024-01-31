using UnityEngine;
using UnityEngine.Events;

public class OnMouseEnterBehaviour : MonoBehaviour
{
    public UnityEvent mouseEnterEvent, mouseOverEvent, mouseExitEvent;
    private bool isOver;

    private void OnMouseEnter()
    {
        //Set the isOver bool to true and invoke the attached event to when the enters over an object
        isOver = true;
        mouseEnterEvent.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }

    private void OnMouseExit()
    {
        //isOver is set to false and exit event in invoked
        isOver = false;
        mouseExitEvent.Invoke();
    }
}
