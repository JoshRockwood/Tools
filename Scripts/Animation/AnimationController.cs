using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    private bool isJumping;
    private readonly int idle = Animator.StringToHash("Idle");
    private readonly int walk = Animator.StringToHash("Walk");
    private readonly int jump = Animator.StringToHash("Jump");
    private readonly int run = Animator.StringToHash("Run");

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        HandleJumpToIdle(); 
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            animator.SetTrigger(jump);
            isJumping = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger(walk);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetTrigger(idle);
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) && !isJumping)
        {
            animator.SetTrigger(run);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            animator.SetTrigger(idle);
        }
    }

    private void HandleJumpToIdle()
    {
        if (!isJumping || !animator.GetCurrentAnimatorStateInfo(0).IsName("Idle")) return;
        animator.SetTrigger(idle);
        isJumping = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger(idle);
    }
}
