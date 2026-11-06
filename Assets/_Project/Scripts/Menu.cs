using UnityEngine;

public class Menu : MonoBehaviour
{
    private Animator animator;

    public void Switch(bool on)
    {
        //gameObject.SetActive(on);
        CheckIfHasAnimator();
        animator.SetBool("IsVisible", on);
    }

    void CheckIfHasAnimator()
    {
        if (animator != null)
            return;

        animator = GetComponent<Animator>();
    }
}
