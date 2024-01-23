using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        // Move game object backward
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
