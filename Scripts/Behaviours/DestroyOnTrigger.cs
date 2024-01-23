using System.Collections;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public float holdTime = 0.1f;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return new WaitForSeconds(holdTime);
        Destroy(gameObject);
    }
}
