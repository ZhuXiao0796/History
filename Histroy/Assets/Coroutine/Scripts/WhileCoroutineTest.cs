using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.CoroutineTest
{
    /// <summary>
    /// 当在协程内部用 While 进行判断，在外部打断  While 内的条件，则 While 中止。
    /// </summary>
    public class WhileCoroutineTest : MonoBehaviour
    {
        private bool status;
        // Start is called before the first frame update
        void Start()
        {
            status = true;
            StartCoroutine(WhileTest());
            Invoke("ChangeStatus", 5f);
        }

        private void ChangeStatus()
        {
            status = false;
        }

       private IEnumerator WhileTest()
        {
            while (status)
            {
                Debug.Log(11111);
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
