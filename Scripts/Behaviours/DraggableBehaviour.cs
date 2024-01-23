using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;

    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        // Offsets the position of the object.
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        // Sets the initial bool to true
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    public void OnMouseUp()
    {
        // Sets bool to false when mouse is let go
        draggable = false;
        endDragEvent.Invoke();
    }
}
