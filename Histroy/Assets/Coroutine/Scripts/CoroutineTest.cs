﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CoroutineTest
{
    /// <summary>
    /// 协程的 Yield break 测试
    /// </summary>
    public class CoroutineTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(YieldSeconds());
        }

        /// <summary>
        /// 这个方法主要是用来测试 yield break
        /// </summary>
        /// <returns></returns>
        private IEnumerator AutoBreakTest()
        {
            Debug.Log("One");
            yield return new WaitForSeconds(1f);
            Debug.Log("Two");
            yield break;
            Debug.Log("Null");
        }

        /// <summary>
        /// 这个方法主要是用来测试 yield return 后面跟任意数字的结果
        /// </summary>
        /// <returns></returns>
        private IEnumerator YieldSeconds()
        {
            yield return 0;
            Debug.Log("0");
            yield return 1;
            Debug.Log("1");
            yield return 200;
            Debug.Log("2");
        }
    }
}