using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.CoroutineTest
{
    /// <summary>
    /// 不同帧数下  协程中等待时间的影响
    /// </summary>
    public class FrameAndCoroutineTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //StartCoroutine(WaitForSecondsTest());
            StartCoroutine(WaitForSecondsRealtimeTest());
        }

        private IEnumerator WaitForSecondsTest()
        {
            while (true)
            {
                Debug.Log(Time.realtimeSinceStartup + "当前情况是 WaitForSeconds");
                yield return new WaitForSeconds(1f);
            }
        }

        private IEnumerator WaitForSecondsRealtimeTest()
        {
            while (true)
            {
                Debug.Log(Time.realtimeSinceStartup + "当前情况是 WaitForSecondsRealtime");
                yield return new WaitForSecondsRealtime(1.00000000f);
            }
        }

    }
}
