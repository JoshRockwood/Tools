using System.Collections;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wfsObj;

    private void Start()
    {
        StartCoroutine(DestroyAfterDelay());
    }
    private IEnumerator DestroyAfterDelay()
    {
        wfsObj = new WaitForSeconds(seconds);
        yield return wfsObj;
        Destroy(gameObject);
    }

    public void DestroyNow()
    {
        Destroy(gameObject);
    }
}
