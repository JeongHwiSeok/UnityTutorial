using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AnimationClip[] animationClips;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < animationClips.Length; i++)
        {
            var data = AnimationUtility.GetAnimationClipSettings(animationClips[i]);

            data.loopTime = false;

            AnimationUtility.SetAnimationClipSettings(animationClips[i], data);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ����
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // animator.GetCurrentAnimatorStateInfo(0).normalizedTime
            // ���� ������ �ִϸ��̼��� ���� ���¸� �ǹ�.
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.gameObject.SetActive(false);
            }
        }
    }

    public void Open()
    {
        animator.gameObject.SetActive(true);
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }
}
