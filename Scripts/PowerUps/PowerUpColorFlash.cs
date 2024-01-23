using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpColorFlash : MonoBehaviour
{
    // Create an array containing the material rotation
    public Material[] materials;
    // Time between flashes
    public float flashInterval = 0.5f;
    private int currentMaterialIndex = 0;
    private Renderer powerUpRenderer;

    private void Start()
    {
        powerUpRenderer = GetComponent<Renderer>();
        StartCoroutine(FlashColors());
    }

    private IEnumerator FlashColors()
    {
        while (true)
        {
            yield return new WaitForSeconds(flashInterval);
            currentMaterialIndex = (currentMaterialIndex + 1) % materials.Length;
            powerUpRenderer.material = materials[currentMaterialIndex];
        }
    }
}
