using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.UnityAPI.ReferenceTest
{
    /// <summary>
    /// 用来测试物体 SetActive(False) 之后引用关系是否还存在
    /// </summary>
    public class SetActiveTest : MonoBehaviour
    {
        public GameObject A;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SetActiveReferenceTest());
        }

        private IEnumerator SetActiveReferenceTest()
        {
            yield return new WaitForSeconds(5f);
            A.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(A.name);
        }
    }
}
