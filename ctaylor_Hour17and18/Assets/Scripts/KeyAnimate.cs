using UnityEngine;

public class KeyAnimate : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Color");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Scale");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Spin");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Hover");
        }
    }
}
