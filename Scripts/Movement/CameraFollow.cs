using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public string playerTag = "Player";
    public Vector3 cameraOffset = new Vector3(0f, 2f, -5f);

    public void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);

        if (player != null)
        {
            // Sets the camera's position to the player's position
            transform.position = player.transform.position + cameraOffset;
        }
    }
}
