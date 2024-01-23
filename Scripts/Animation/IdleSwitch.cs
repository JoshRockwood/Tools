using UnityEngine;
using System.Collections;

public class IdleSwitch : MonoBehaviour
{
    private Animator animator;
    public float switchIntervalIdleState1 = 3f;
    public float switchIntervalIdleState2 = 2.1f; 
    public string idleState1 = "Idle";
    public string idleState2 = "Idle Turn";

    private void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(SwitchIdleAnimations());
    }

    private IEnumerator SwitchIdleAnimations()
    {
        while (true) 
        {
            animator.Play(idleState1);

            yield return new WaitForSeconds(switchIntervalIdleState1);

            animator.Play(idleState2);

            yield return new WaitForSeconds(switchIntervalIdleState2);
        }
    }
}