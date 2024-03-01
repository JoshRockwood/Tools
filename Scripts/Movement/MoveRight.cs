using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        // Move GameObject forward
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
