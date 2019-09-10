using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.TransformTest
{
    /// <summary>
    /// 测试了 好奇很久的 当前坐标的前后左右的实际值
    /// </summary>
    public class TransformTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(transform.position);
            transform.position = new Vector3(0,10,0);
            Debug.Log(transform.position);
            //transform.position.
            //Debug.Log(transform.up);
            //Debug.Log(transform.forward);
            //Debug.Log(transform.right);
        }
    }
}
