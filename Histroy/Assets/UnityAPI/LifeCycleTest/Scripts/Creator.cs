using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.LifeCycleTest
{
    public class Creator : MonoBehaviour
    {
        public GameObject A;
        // Start is called before the first frame update
        void Start()
        {
            //Invoke("CreatorMethod", 5f);
            StartCoroutine(CreatorMethod());
        }

        public IEnumerator CreatorMethod()
        {
            yield return new WaitForSeconds(2f);
            var go = Instantiate(A);
            Debug.Log(Time.realtimeSinceStartup + "Creator 的 时间");
            //yield return new WaitForSeconds(4f);
            //yield return new WaitForEndOfFrame();
            yield return new WaitForFixedUpdate();
            Debug.Log("当前方法结束");
            yield break;
        }
    }
}
