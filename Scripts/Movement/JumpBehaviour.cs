using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class JumpBehaviour : MonoBehaviour
{
    public float jumpForce = 4f;
    public float gravity = -9.81f;
    private CharacterController controller;
    private Vector3 velocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    public void Jump()
    {
        Debug.Log("Jump Method Called");
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }

        if (controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2 * gravity);
        }
    }
}
