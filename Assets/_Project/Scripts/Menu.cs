using UnityEngine;

public class Menu : MonoBehaviour
{
    private Animator animator;

    public void Initialize()
    {
        animator = GetComponent<Animator>();
    }

    public void Switch(bool on)
    {
        animator.SetBool("IsVisible", on);
    }
}
