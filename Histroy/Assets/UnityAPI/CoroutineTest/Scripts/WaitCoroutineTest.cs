using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.CoroutineTest
{
    /// <summary>
    /// 这个类用来测试当前协程执行到一半的时候需要等待其他协程执行完再继续执行
    /// 简：测试 yield return StartCoroutine
    /// </summary>
    public class WaitCoroutineTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(WaitCoroutine());
        }

        private IEnumerator WaitCoroutine()
        {
            yield return StartCoroutine(ClockTick());
            Debug.Log("Finished");
        }

        private IEnumerator ClockTick()
        {
            for (int i = 0; i < 10; i++)
            {
                Debug.Log(i);
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
