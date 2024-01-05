using UnityEngine;

public class AnimationButton : MonoBehaviour
{
    public Animator animator;
    public string animationTriggerName; 


    public void PlayAnimation()
    {

        // Jouez l'animation
        if (animator != null && !string.IsNullOrEmpty(animationTriggerName))
        {
            animator.SetTrigger(animationTriggerName);
        }
    }
}