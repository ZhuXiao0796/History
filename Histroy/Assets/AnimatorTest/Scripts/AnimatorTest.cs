using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.AnimatorTest
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
        }

        //如果我在 Update 中不断调用 animator.SetTrigger
        //那么动画是否能正常播放呢
        void Update()
        {
            //Animator.SetTrigger("hit");
        }
    }
}
