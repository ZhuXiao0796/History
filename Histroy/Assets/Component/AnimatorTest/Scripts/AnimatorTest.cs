using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.AnimatorTest
{
    /// <summary>
    /// 动画机测试脚本
    /// </summary>
    public class AnimatorTest : MonoBehaviour
    {
        Animator Animator;
        // Start is called before the first frame update
        void Start()
        {
            Animator = GetComponent<Animator>();
            Animator.speed = 0.5f;
            //Animator.SetTrigger("hit");
            StartCoroutine(AnimatorTestMethod());
        }

        private IEnumerator AnimatorTestMethod()
        {
            yield return new WaitForSeconds(5f);
            //Animator.SetTrigger("idle");
            Animator.speed = 1;
        }
    }
}
