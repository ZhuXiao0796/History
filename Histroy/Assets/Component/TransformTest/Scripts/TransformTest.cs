using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace History.ComponentTest.TransformTest
{
    /// <summary>
    /// 测试了 好奇很久的 当前坐标的前后左右的实际值
    /// 测试了 新了解到的属性 hasChanged
    /// 测试 transform.forward
    /// </summary>
    public class TransformTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //HierarchyCapacityTest();
        }
        void DirectionTest()
        {
            Debug.Log(transform.position);
            transform.position = new Vector3(0, 10, 0);
            Debug.Log(transform.position);
            //transform.position.
            Debug.Log(transform.up);
            Debug.Log(transform.forward);
            Debug.Log(transform.right);
        }

        void PosChange()
        {
            if (transform.hasChanged)
            {
                Debug.Log("Has Changed");
            }
        }

        void HierarchyCapacityTest()
        {
            Debug.Log(transform.hierarchyCapacity);
        }

        void TransformForwardTest()
        {
            transform.LookAt(transform.forward);
        }

        /// <summary>
        ///  Transform 本地 角度朝向测试
        /// </summary>
        void TransformLocalRotationTest()
        {
            transform.localRotation = Quaternion.Euler(new Vector3());
        }

        private void Update()
        {
            TransformForwardTest();
        }
    }
}
