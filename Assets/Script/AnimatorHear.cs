using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class AnimatorHear : MonoBehaviour
{
    public Animator animator;

    public void ClickMe()
    {
        animator.SetTrigger("MouseClick");
    }
}
