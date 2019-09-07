using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.TransformTest
{
    /// <summary>
    /// 测试 Transform 角度对 Vector3.MoveToward 的影响
    /// </summary>
    public class DirectionTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(MoveTowardsTest());
        }

        private IEnumerator MoveTowardsTest()
        {
            while (true)
            {
                //transform.position = Vector3.MoveTowards(transform.position,transform.TransformPoint( transform.position + transform.forward*5),Time.deltaTime*1);
                transform.position = Vector3.MoveTowards(transform.position,transform.forward + transform.position,Time.deltaTime*1);
                
                yield return null;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}